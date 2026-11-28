param([Parameter(Mandatory=$true)][string]$PackagePath, [Parameter(Mandatory=$true)][string]$OutputDirectory)
$ErrorActionPreference='Stop'
$package=(Resolve-Path -LiteralPath $PackagePath).Path
$OutputDirectory=(New-Item -ItemType Directory -Force -Path $OutputDirectory).FullName
& "$env:WINDIR\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /nologo /target:library "/out:$OutputDirectory\CMOContext.dll" (Join-Path $PSScriptRoot 'ContextualHtml.cs')
if ($LASTEXITCODE -ne 0) { throw 'Context helper compilation failed' }
$h=[Reflection.Assembly]::LoadFrom((Resolve-Path (Join-Path $package '0Harmony.dll')).Path)
$read=$h.GetType('Mono.Cecil.AssemblyDefinition').GetMethod('ReadAssembly',[type[]]@([string]))
$a=$read.Invoke($null,@((Resolve-Path (Join-Path $package 'CMOKorean.dll')).Path))
$m=($a.MainModule.Types | Where-Object FullName -eq 'CMOKorean.HtmlTranslation').Methods | Where-Object Name -eq 'Translate'
if (@($m).Count -ne 1 -or $m.Parameters.Count -ne 1) { throw 'Unexpected Translate signature' }
if ($a.MainModule.AssemblyReferences.Name -contains 'CMOContext') { throw 'Already patched' }
$helper=[Reflection.Assembly]::LoadFrom((Join-Path $OutputDirectory 'CMOContext.dll'))
$prepare=$helper.GetType('CMOKorean.ContextSupport.ContextualHtml').GetMethod('Prepare')
$import=$a.MainModule.GetType().GetMethod('ImportReference',[type[]]@([Reflection.MethodBase]))
$reference=$import.Invoke($a.MainModule,@($prepare))
$il=$m.Body.GetILProcessor();$first=$m.Body.Instructions[0]
$op=$h.GetType('Mono.Cecil.Cil.OpCodes')
$ld=$op.GetField('Ldarg_0').GetValue($null)
$call=$op.GetField('Call').GetValue($null)
$st=$op.GetField('Starg').GetValue($null)
$il.InsertBefore($first,$il.Create($ld))
$il.InsertBefore($first,$il.Create($call,$reference))
$il.InsertBefore($first,$il.Create($st,$m.Parameters[0]))
$a.Write((Join-Path $OutputDirectory 'CMOKorean.dll'))
Copy-Item -LiteralPath (Join-Path $package '0Harmony.dll') -Destination (Join-Path $OutputDirectory '0Harmony.dll') -Force
Write-Output 'Created isolated CMOKorean.dll with reviewed-block preprocessing'
$rows=Get-Content -LiteralPath (Join-Path $PSScriptRoot '..\reviews\context-blocks.json') -Raw -Encoding UTF8 | ConvertFrom-Json
$lines=@(foreach($row in $rows) {
  if ($row.source_sha256 -cnotmatch '^[0-9a-f]{64}$' -or [string]::IsNullOrWhiteSpace($row.translation)) { throw 'Invalid reviewed context block' }
  $row.source_sha256+"`t"+[Convert]::ToBase64String([Text.Encoding]::UTF8.GetBytes($row.translation))
})
[IO.File]::WriteAllText((Join-Path $OutputDirectory 'context-html.b64.tsv'),($lines -join "`r`n")+"`r`n",[Text.UTF8Encoding]::new($true))
