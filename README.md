# CMO Korean Patch / 커맨드: 모던 오퍼레이션스 한국어 패치

**Unofficial · Free & non-commercial · Preview / 비공식 · 무료·비상업 · 검수 중**

Maintainer / 관리자: [dlwns147](https://github.com/dlwns147)  
Repository / 저장소: https://github.com/dlwns147/cmo-korean-patch  
Contact / 연락처: [lsj000777@naver.com](mailto:lsj000777@naver.com)

---

## 한국어

### 소개

이 프로젝트는 **OpenAI Codex를 활용하여 개발 및 번역 작업을 진행했습니다.** 모드 코드 작성·수정, 번역 문구 교정, 테스트 및 배포 패키지 정리에 Codex의 도움을 받았습니다. 번역 초안 생성에는 아래에 명시한 NLLB 모델도 사용했습니다.

Command: Modern Operations의 UI, 지도 지명, 장비 설명, 시나리오 브리핑을 한국어로 표시하는 비공식 패치입니다. 제작사 또는 퍼블리셔와 제휴하거나 승인을 받은 공식 번역이 아닙니다. 무료·비상업 목적으로 제공하며 유료 판매나 유료 접근을 목적으로 하지 않습니다.

저장된 번역을 화면 표시 전에 불러옵니다. 별도의 실시간 번역 모델이나 번역 서버는 필요하지 않습니다. 기계 번역 초안과 수동 교정이 혼재하므로 오역·영어 잔존·표시 오류가 있을 수 있습니다.

메인 지도 단축키 메뉴는 **게임 원본 버튼의 배경·테두리·아이콘을 유지하고 글자 영역만 한글로 교체**합니다. 설치 시 사용자 게임의 이미지로 한글 버튼 13개를 생성해 `CMO-Korean/buttons-original-ko-v1`에 저장합니다. 게임에서는 저장된 이미지를 한 번 읽어 재사용하며, 화면을 그릴 때 번역하거나 이미지를 다시 생성하지 않습니다. 원본 이미지 파일은 변경하지 않고 배포 ZIP에도 포함하지 않습니다. 기존 클릭 동작과 선택·비활성 표시는 게임의 기본 처리를 유지합니다.

### 다운로드 및 설치

저장소의 [downloads 폴더](https://github.com/dlwns147/cmo-korean-patch/tree/main/downloads)에서 `CMO-Korean-v0.2-translation-only.zip`을 선택하고 **Download raw file**로 받으세요. GitHub의 소스 코드 ZIP 대신 이 설치용 ZIP을 사용합니다. 다운로드 후 압축을 완전히 풉니다.

1. 게임을 종료합니다.
2. `Install.cmd`를 실행합니다. 기본 Steam 경로를 사용합니다.
3. 게임을 평소처럼 실행합니다.

다른 경로에 설치했다면 PowerShell에서 실행합니다.

```powershell
.\Install.ps1 -GamePath 'D:\SteamLibrary\steamapps\common\Command - Modern Operations'
```

검증 대상은 **Windows 64비트, CMO v1.10 / 빌드 1900.24**입니다. Windows PowerShell 5.1과 .NET Framework 4.x를 사용합니다. 설치기는 게임 실행 파일 해시를 검사하며 다른 빌드는 거부합니다. 다른 AppDomainManager 모드 또는 기존 Harmony DLL과 충돌할 수도 있습니다. 접근 권한 오류가 있을 때만 설치기를 관리자 권한으로 실행하세요.

기존 패치를 사용 중이면 기존 버전의 `Restore.cmd`로 먼저 복원합니다. 게임 업데이트로 파일이 변경되어 복원이 거부되면 강제로 덮어쓰지 마세요. 원본 백업은 삭제하지 마세요.

### 제거 및 검증

게임을 종료한 후 `Restore.cmd`를 실행합니다. 사용자 지정 경로에서는 `Restore.ps1 -GamePath '게임 경로'`를 사용합니다. 원본 백업은 게임 폴더의 `CMO-Korean/backup`에 유지됩니다.

ZIP 옆의 `.sha256` 파일은 다운로드 파일 검증용이며 ZIP 안의 `SHA256SUMS.txt`는 개별 파일 검증용입니다. 자동 검사 60개와 GDI/DirectWrite 표시 검사를 통과했습니다. 이 배포 버전의 모든 실제 게임 화면과 전체 시나리오를 검증했다는 뜻은 아닙니다.

### 포함·제외 범위

- 한국어 사전, 번역 표시 DLL 및 필수 Harmony 라이브러리, 번역 장비 설명, 지도 지명, 런처 한국어 리소스, 설치·복원 도구를 포함합니다.
- 영어 설명 본문 6,267개를 제거하고 UI·시나리오 사전의 원문 조회 키를 SHA-256 해시로 변경했습니다. 사용자 게임에서 얻은 원문을 해시로 대조합니다.
- HTML 파일 348개와 내부 이미지, 게임 실행 파일·전투 DB·원본 시나리오·세이브·DLC 원본·번역 모델을 배포하지 않습니다.
- 약어, 장비 식별자, 공개 지명 데이터, 자료 출처는 남을 수 있습니다. 모든 영문자를 제거한 파일이라는 의미는 아닙니다.
- HTML 교체를 제외해 일부 이미지 속 글자와 기존 HTML 수동 수정분의 번역 범위가 줄어들 수 있습니다. 사전에 없는 문장은 자동으로 새로 번역하지 않습니다.

### 번역 검수 현황 — 2026-11-26

UI·지도 사전·시나리오 사전·DB 설명에서 중복을 제거한 71,229개 항목을 목록화하고 자동 검사했습니다. 이번 확장 작업은 2,388개 항목을 대상으로 문맥 교정, 제원표 복원, 원문 조건부 용어 수정을 반영했습니다. DB 2,037개 파일의 4,110개 문단 위치와 UI 90개 항목을 갱신했습니다. 시나리오의 교전·사격 금지 조건, 부대 편제, 탐색구조 절차와 긴 무장·센서 설명의 누락을 보완했습니다. 원문 자체가 손상된 부분은 추측하지 않고 표시했습니다.

Codex가 직접 문장을 작성하고 검수했으며 새 로컬 번역 모델은 사용하지 않았습니다. **전체 직접 검수는 아직 완료되지 않았습니다.** 현재 검수 기록은 직접 검수 1,214개, 용어만 교정한 항목 1,275개이며, 나머지 68,740개는 이 검수 기록에서 직접 검수 완료로 표시하지 않았습니다. 깨진 문자와 어색한 기계번역이 여전히 남아 있습니다. 자동 검사·용어 수정은 문장 전체의 의미와 자연스러움을 검수한 것과 다릅니다.

Community Scenario Pack 640개의 제목·브리핑 HTML 텍스트 7,250개를 조회 검사하고 누락 문구 53개를 추가했습니다. 사전과 정확히 일치하지 않는 19개는 약어·저자명·이메일·문장 조각 등을 포함합니다. 이 검사는 Lua 메시지나 첨부 문서 전체의 한글화·검수 완료를 뜻하지 않습니다.

기존 자동 검사 60개, GDI/DirectWrite 첫 표시 검사와 저장된 번역의 첫 호출 검사 2,392개를 통과했습니다. 실제 게임 전 화면의 재검증은 완료되지 않았습니다. 게임을 재시작하면 갱신된 사전을 읽습니다. 세부 현황은 [TRANSLATION-REVIEW.json](TRANSLATION-REVIEW.json)에 기록했습니다.

### 저작권·라이선스 및 비상업 목적

이 저장소 전체에 MIT 등 단일 오픈소스 라이선스를 부여하지 않습니다. 직접 작성된 코드, 게임 번역물, 외부 라이브러리와 데이터의 권리는 구분됩니다.

| 구성요소 | 조건 및 출처 |
|---|---|
| CMO 게임 원문과 번역물 | 원문과 관련 권리는 각 권리자에게 있습니다. [CMO EULA](https://store.steampowered.com//eula/1076160_eula_0)와 [퍼블리셔 모드 정책](https://www6.slitherine.com/terms-of-use)이 적용될 수 있습니다. 이 패치에 대한 서면 배포 승인을 확보했다고 주장하지 않습니다. |
| 커뮤니티 시나리오 번역 | 개별 작성자의 권리와 배포 조건을 존중합니다. 포괄 재배포 허락이 확인된 것으로 표시하지 않습니다. |
| Harmony 2.4.3 | MIT, Copyright (c) 2017 Andreas Pardeike. `HARMONY-LICENSE.txt`의 저작권·허락문을 유지합니다. [원 라이선스](https://github.com/pardeike/Harmony/blob/master/LICENSE) |
| GeoNames | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/). [GeoNames 데이터](https://download.geonames.org/export/dump/readme.txt)의 도시명·좌표를 사용하고 한국어 표기를 교정·음차했습니다. |
| Natural Earth | [퍼블릭 도메인](https://www.naturalearthdata.com/about/terms-of-use/). 지도 지명을 한국어로 변환했습니다. |
| NLLB-200 distilled 600M | 번역 초안 생성에 사용한 모델은 [CC BY-NC 4.0](https://huggingface.co/facebook/nllb-200-distilled-600M)입니다. 모델과 엔진은 배포하지 않습니다. 모델 라이선스가 번역 출력 전체에 자동 적용되거나 원문의 권리를 대체한다고 주장하지 않습니다. |

**비상업 배포와 영어 원문·이미지 제거만으로 번역물의 배포 허락이 자동으로 생기지는 않습니다.** 전체 번역물에 대한 권리 확인은 완료되지 않았습니다. 자세한 구성요소 출처는 `THIRD-PARTY.md`를 참조하세요.

### 권리 문제 제기 및 비공개 전환

**저작권·라이선스 문제가 제기되거나 권리자의 요청이 있는 경우, 확인을 위해 해당 저장소를 비공개로 전환하고 배포를 중단하겠습니다.** 이후 해당 자료의 삭제·수정 또는 권리자의 안내에 따른 조치를 진행하겠습니다. 연락 시 문제가 되는 파일·문구와 권리 관계를 알려 주세요. 비공개 전환으로 이미 다운로드되거나 복제된 사본까지 회수할 수 있는 것은 아닙니다.

문의: **lsj000777@naver.com** · GitHub: **dlwns147**

---

## English

### About

This project was **developed with assistance from OpenAI Codex**. Codex assisted with writing and updating the mod code, revising translations, testing, and preparing the distribution package. The NLLB model listed below was also used to generate draft translations.

An unofficial Korean localization patch for Command: Modern Operations, covering UI text, map labels, equipment descriptions and scenario briefings. It is not affiliated with or officially endorsed by the developer or publisher. The project is provided free of charge for non-commercial purposes, with no paid access or sale intended.

Translations are loaded from stored dictionaries before display. No live translation model or translation server is required. Machine-generated drafts and manual corrections are mixed; mistranslations, untranslated text and display issues remain.

The main map shortcut toolbar **preserves the original game button backgrounds, borders and icons, replacing only the lettering area with Korean**. During installation, 13 localized images are generated from the user’s local game assets and saved under `CMO-Korean/buttons-original-ko-v1`. The game loads these once and reuses them; no translation or image generation occurs during rendering. Original image files are not modified or included in the ZIP. Native click handling and selected/disabled rendering are retained.

### Download and installation

Open the [downloads folder](https://github.com/dlwns147/cmo-korean-patch/tree/main/downloads), select `CMO-Korean-v0.2-translation-only.zip`, and use **Download raw file**. Use this installer ZIP rather than GitHub's source archive. Extract it completely.

1. Close the game.
2. Run `Install.cmd`, which uses the default Steam installation path.
3. Launch the game normally.

For a custom path, run:

```powershell
.\Install.ps1 -GamePath 'D:\SteamLibrary\steamapps\common\Command - Modern Operations'
```

Tested target: **64-bit Windows, CMO v1.10 / build 1900.24**, using Windows PowerShell 5.1 and .NET Framework 4.x. The installer checks the game executable hash and rejects other builds. Other AppDomainManager mods or an existing Harmony DLL may conflict. Run the installer as administrator only if file access is denied.

If an earlier patch is installed, restore it using that version's `Restore.cmd` first. Do not force replacement when restoration refuses files changed by a game update, and do not delete the original backups.

### Uninstallation and validation

Close the game and run `Restore.cmd`, or `Restore.ps1 -GamePath 'your game path'`. Backups remain under `CMO-Korean/backup` in the game directory.

The adjacent `.sha256` verifies the ZIP; `SHA256SUMS.txt` inside it verifies individual files. The patch passed 60 automated checks plus GDI/DirectWrite display checks. Additional checks verify unchanged original icon/border pixels, preserved button behavior and only 13 image loads over 1,001 preparation calls. This does not mean every in-game screen and scenario has been tested with this release.

### Package scope

- Includes Korean dictionaries, the localization DLL and required Harmony library, translated equipment descriptions, map labels, launcher resources and installation/restoration scripts.
- Removes English description bodies from 6,267 files. UI/scenario lookup keys use SHA-256 hashes instead of stored English source passages. Source text is read from the user's game for matching.
- Excludes 348 HTML files and their embedded images, game executables, combat databases, original scenario/save files, original DLC files and translation models.
- Abbreviations, equipment identifiers, public geographic names and attribution references may still contain English.
- Omitting replacement HTML may reduce coverage of text embedded in images and some previously edited HTML. Unknown text is not translated automatically at runtime.

### Translation review status — 2026-11-26

A total of 71,229 unique entries across the UI, map and scenario dictionaries and DB descriptions were inventoried and automatically screened. This expanded pass addresses 2,388 entries through contextual rewriting, performance-table restoration and source-constrained terminology corrections. It updates 4,110 paragraph positions across 2,037 DB files and 90 UI entries. Corrections restore engagement restrictions, unit composition, rescue procedures and omitted equipment details. Damaged source text is explicitly identified rather than reconstructed by guesswork.

Codex directly authored and reviewed the wording; no new local translation model was used. **The complete direct review is unfinished.** The current ledger records 1,214 directly reviewed entries and 1,275 terminology-only corrections; the remaining 68,740 entries have not been marked directly reviewed in this ledger. Corrupted characters and awkward machine translations remain. Automatic screening and terminology edits do not constitute full semantic or stylistic review.

An exact-lookup audit covered 7,250 title/briefing HTML text nodes across 640 Community Scenario Pack scenarios, adding 53 missing translations. The remaining 19 unmatched nodes include acronyms, author names, email addresses and sentence fragments. This audit does not establish complete translation or review of Lua messages and briefing attachments.

Validation passed the existing 60 automated checks, GDI/DirectWrite first-display checks and 2,392 first-call saved-translation checks. A full visual recheck of every game screen is still pending. Restart the game to load the updated dictionaries. See [TRANSLATION-REVIEW.json](TRANSLATION-REVIEW.json) for the recorded scope and results.

### Copyright, licenses and non-commercial purpose

No blanket MIT or other open-source license is granted to the entire repository. Original code, translated game content, third-party libraries and datasets have distinct rights.

| Component | Terms and attribution |
|---|---|
| CMO source content and translations | Relevant rights remain with their respective holders. See the [CMO EULA](https://store.steampowered.com//eula/1076160_eula_0) and [publisher's mod policy](https://www6.slitherine.com/terms-of-use). Written distribution approval for this patch is not claimed. |
| Community-scenario translations | Individual authors' rights and distribution conditions must be respected. Blanket redistribution permission has not been established. |
| Harmony 2.4.3 | MIT, Copyright (c) 2017 Andreas Pardeike. The copyright and permission notice is included in `HARMONY-LICENSE.txt`. [Upstream license](https://github.com/pardeike/Harmony/blob/master/LICENSE) |
| GeoNames | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/). City names and coordinates come from [GeoNames](https://download.geonames.org/export/dump/readme.txt); Korean names were corrected or transliterated. |
| Natural Earth | [Public domain](https://www.naturalearthdata.com/about/terms-of-use/). Geographic labels were translated into Korean. |
| NLLB-200 distilled 600M | The model used to generate draft translations is [CC BY-NC 4.0](https://huggingface.co/facebook/nllb-200-distilled-600M). Model weights and the engine are not distributed. We do not claim its license automatically governs all generated text or replaces rights in the original content. |

**Non-commercial distribution and removal of English originals/images do not automatically grant permission to distribute translations.** Rights clearance for all translated content is not complete. See `THIRD-PARTY.md` for further attribution.

### Rights concerns and repository visibility

**If a copyright or licensing concern is raised, or a rights holder requests action, I will make this repository private and suspend distribution while reviewing the issue.** I will then remove or amend the relevant material, or take action in accordance with the rights holder's guidance. Please identify the affected files/passages and relevant rights when contacting me. Making the repository private cannot recall copies already downloaded or cloned.

Contact: **lsj000777@naver.com** · GitHub: **dlwns147**

### 원문 대조 추가 검수 진행 상황

게임 원문과 사전 키의 SHA-256을 대조해 추가 검수를 진행하고 있습니다. 이번 작업에서는 7,606개 원문 항목을 직접 검수하고 실제 번역 조회 함수로 검증했습니다. 이 중 6,272개는 번역을 수정했고, 1,334개는 기존 번역을 유지했습니다. 전체 검수 완료를 의미하지 않으며, 이전 검수 통계와 중복될 수 있으므로 합산하지 않습니다. 상세 수정 기록은 [추가 검수 기록](https://github.com/dlwns147/cmo-korean-patch/blob/main/reviews/2026-11-26-direct-review.json)에 보관합니다. 영어 원문은 로컬 검수에만 사용하며 배포하지 않습니다.

시나리오 문구가 UI 번역과 충돌할 때 시나리오 사전의 정확한 번역을 우선 조회하도록 수정했습니다. 예를 들어 `Clear`는 UI에서 ‘지우기’, 시나리오의 날씨에서는 ‘맑음’으로 구분합니다. 변경 재현용 스크립트는 [tools/fix-scenario-priority.py](tools/fix-scenario-priority.py)에 있습니다.
