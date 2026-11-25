"""Give exact scenario translations priority over generic UI translations.

For the v0.2 CMOKorean.dll identified below, change only the two initial
Runtime.TranslateScenario ldsfld operands from Words to ScenarioWords.
Both fields have the same HashedWords type; method size and branch targets
are unchanged. UI Translate is unchanged. Requires Python 3, no libraries.
"""
import hashlib
import sys
from pathlib import Path

BASE_SHA256 = '60b4010042459e2123eb7f7f70795dfdc77f73b4b576242ed18116bd13f78240'

def patch(data):
    if hashlib.sha256(data).hexdigest() != BASE_SHA256:
        raise ValueError('Unsupported DLL; expected the original v0.2 runtime')
    data = bytearray(data)
    for offset in (2710, 2730):
        assert data[offset:offset + 5] == bytes.fromhex('7e04000004')
        data[offset + 1:offset + 5] = bytes.fromhex('0e000004')
    return bytes(data)

if __name__ == '__main__':
    path = Path(sys.argv[1])
    result = patch(path.read_bytes())
    path.write_bytes(result)
    print(hashlib.sha256(result).hexdigest())
