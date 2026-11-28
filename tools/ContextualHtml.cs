using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace CMOKorean.ContextSupport {
    // Only explicitly reviewed, byte-identical original blocks are replaced.
    public static class ContextualHtml {
        static readonly Regex Tags = new Regex(@"<!--[\s\S]*?-->|<(?:(?:""[^""]*"")|(?:'[^']*')|[^'"">])*>", RegexOptions.CultureInvariant);
        static readonly Regex TagName = new Regex(@"^<\s*(/?)\s*([A-Za-z][A-Za-z0-9:_-]*)", RegexOptions.CultureInvariant);
        static readonly Dictionary<string,string> Blocks = Load();
        static Dictionary<string,string> Load() {
            var result = new Dictionary<string,string>(StringComparer.Ordinal);
            try {
                string root = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string file = Path.Combine(root, "context-html.b64.tsv");
                if (!File.Exists(file)) file = Path.Combine(root, "CMO-Korean", "context-html.b64.tsv");
                if (!File.Exists(file)) return result;
                foreach (string line in File.ReadAllLines(file, Encoding.UTF8)) {
                    if (String.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                    string[] fields = line.Split('\t');
                    if (fields.Length != 2 || !Regex.IsMatch(fields[0], @"\A[0-9a-f]{64}\z")) continue;
                    string target = Encoding.UTF8.GetString(Convert.FromBase64String(fields[1]));
                    if (String.IsNullOrWhiteSpace(target)) continue;
                    // The distributable dictionary contains hashes and Korean only.
                    result[fields[0]] = target;
                }
            } catch { result.Clear(); }
            return result;
        }
        public static string Prepare(string html) {
            if (String.IsNullOrEmpty(html) || Blocks.Count == 0) return html;
            try { return ReplaceReviewedBlocks(html); } catch { return html; }
        }
        static bool TryReviewed(string source, out string target) {
            target = null;
            if (source.IndexOf("cmo-ko-source", StringComparison.OrdinalIgnoreCase) >= 0 || source.Contains("[ENGLISH ORIGINAL]")) return false;
            // Do not remove links, media, forms, nested blocks, or executable content.
            foreach (Match token in Tags.Matches(source)) {
                // Word-exported scenario HTML uses inert Office smart tags.
                if (Regex.IsMatch(token.Value, @"\A<\?xml:namespace\b[^<>]*/>\z", RegexOptions.IgnoreCase)) continue;
                Match name = TagName.Match(token.Value);
                if (!name.Success) return false;
                if (!Regex.IsMatch(name.Groups[2].Value, @"\A(p|li|div|span|font|b|strong|i|em|u|s|small|big|sub|sup|br|o:p|(?:u[0-9]+|st[0-9]+):(?:place|placetype|placename|country-region|city|state|street|address|date|time))\z", RegexOptions.IgnoreCase)) return false;
            }
            string hash;
            using (var sha = SHA256.Create()) hash = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(source))).Replace("-", "").ToLowerInvariant();
            return Blocks.TryGetValue(hash, out target);
        }
        static string ReplaceReviewedBlocks(string html) {
            var output = new StringBuilder(html.Length);
            var names = new List<string>();
            var protectedScopes = new List<bool>();
            int emitted = 0, previousEnd = 0, skipUntil = 0, originalDepth = -1;
            foreach (Match token in Tags.Matches(html)) {
                if (token.Index < skipUntil) continue;
                if (token.Index > previousEnd && html.Substring(previousEnd, token.Index - previousEnd).Contains("[ENGLISH ORIGINAL]")) originalDepth = names.Count;
                previousEnd = token.Index + token.Length;
                Match parsed = TagName.Match(token.Value);
                if (!parsed.Success) continue;
                string name = parsed.Groups[2].Value.ToLowerInvariant();
                bool closing = parsed.Groups[1].Value == "/";
                if (closing) {
                    int index = names.LastIndexOf(name);
                    if (index >= 0) { names.RemoveRange(index, names.Count-index); protectedScopes.RemoveRange(index, protectedScopes.Count-index); }
                    if (originalDepth >= 0 && names.Count < originalDepth) originalDepth = -1;
                    continue;
                }
                bool blocked = originalDepth >= 0 || (protectedScopes.Count > 0 && protectedScopes[protectedScopes.Count-1]);
                bool ownBlock = Regex.IsMatch(name, @"^(script|style|textarea|pre|code|select)$") || token.Value.IndexOf("cmo-ko-source", StringComparison.OrdinalIgnoreCase) >= 0;
                if (!blocked && !ownBlock && (name == "p" || name == "li")) {
                    Match end = Regex.Match(html.Substring(previousEnd), @"</\s*" + name + @"\s*>", RegexOptions.IgnoreCase);
                    if (end.Success) {
                        int endIndex = previousEnd + end.Index + end.Length;
                        string source = html.Substring(token.Index, endIndex-token.Index), target;
                        if (TryReviewed(source, out target)) {
                            output.Append(html, emitted, token.Index-emitted);
                            output.Append(token.Value);
                            output.Append("<span class=\"cmo-ko-source\" lang=\"ko\">");
                            output.Append(WebUtility.HtmlEncode(target));
                            output.Append("</span>");
                            output.Append(end.Value);
                            emitted = endIndex; skipUntil = endIndex; previousEnd = endIndex;
                            continue;
                        }
                    }
                }
                if (token.Value.EndsWith("/>") || Regex.IsMatch(name, @"^(br|hr|img|input|meta|link|source|wbr)$")) continue;
                names.Add(name); protectedScopes.Add(blocked || ownBlock);
            }
            output.Append(html, emitted, html.Length-emitted);
            return output.ToString();
        }
    }
}
