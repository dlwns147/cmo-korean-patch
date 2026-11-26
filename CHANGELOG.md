# v0.2-translation-only — 2026-11-25

무료·비상업 배포 목적의 번역 전용 패키지입니다.

- 영어 원문 사전 키를 SHA-256으로 대체하고 런타임 조회를 변경했습니다.
- 장비 설명 6,267개에서 원문 본문을 제거하고 자료 출처를 유지했습니다.
- HTML 348개와 내부 이미지, 번역되지 않은 사전 항목을 제외했습니다.
- 자동 검사 60개 및 GDI/DirectWrite 검사 통과. 실제 게임의 전 화면 재검증은 하지 않았습니다.
- 번역물의 공개 허락은 별도로 확인해야 합니다.

## 단축키 버튼 표시 수정

- 메인 지도 단축키 메뉴를 기능별 벡터 아이콘·한글 설명·단축키가 있는 버튼으로 표시합니다.
- 마우스 강조, 눌림, 선택, 비활성 상태를 구분합니다. 기존 클릭 처리와 단축키는 유지합니다.
- 게임 이미지 파일을 재배포하지 않고 코드로 도형을 그립니다.

## 원본 디자인의 한글 이미지 버튼 / Original-style Korean image buttons

- 앞선 벡터 버튼 디자인을 원본 이미지 기반으로 교체했습니다. 아이콘·테두리·배경은 유지하고 글자 영역만 바꿉니다.
- 설치 시 로컬 원본에서 13개 이미지를 생성합니다. 원본·생성 이미지는 ZIP에 포함하지 않습니다.
- 런타임은 이미지를 한 번 로드해 재사용합니다. 기존 게임 렌더러와 클릭·선택·비활성 상태를 유지합니다.
- Replace the earlier vector design with locally generated original-style buttons. Generation occurs during installation; original and generated images are not distributed. Cached images are reused without per-frame generation.
- Pixel preservation, state/click behavior and one-time image loading tests passed. Full in-game visual verification remains pending.

- 자동·수동 공격 버튼의 영어 글자 픽셀이 배경에 복사되어 가로줄이 생기던 문제를 수정했습니다. 13개 이미지 전체를 확인했습니다.
- Fixed horizontal artifacts on attack buttons by sampling a verified blank background column. All 13 generated images were visually inspected.

## 2026-11-26 — Codex 직접 문맥 교정 / Direct contextual revisions

- 사전 전체 자동 검사 후 47개 문단을 직접 교정했습니다. DB 설명 595개 파일, 2,579개 문단 위치에 반영했습니다.
- 센서·무장·항속 성능 누락, 사격통제·흘수·대항군·탄약고 등의 오역을 교정했습니다.
- 기존 원문 해시 방식과 영어 본문 미배포 구조를 유지했습니다. 새 로컬 모델은 사용하지 않았습니다.
- Directly revised 47 paragraphs; updated 2,579 DB paragraph occurrences across 595 files. Original-text hashes remain in use. Full direct review remains incomplete.

## 2026-11-26 — 추가 직접 교정 / Further direct review

- F/A-18·P-3·알레이 버크급 및 F-16 센서·무장 설명 27개 문단을 추가 교정했습니다. 186개 파일의 1,252개 문단 위치에 적용했습니다.
- 무장·센서 목록의 누락을 보완하고 비행 성능·정비 용어와 과거 운용 현황의 표현을 다듬었습니다.
- Directly revised 27 additional paragraphs, updating 1,252 occurrences across 186 files. Restored weapon/sensor details and clarified flight-performance, maintenance and historical-service wording.
- 로컬 번역 모델 미사용. 전체 직접 검수는 진행 중입니다. No local translation model used; full direct review remains incomplete.

## 2026-11-26 — 검수 범위 확대 / Expanded review

- UI·지도·시나리오·DB의 고유 항목 71,229개를 목록화했습니다. 전수 직접 검수 완료를 의미하지 않습니다.
- 2,388개 항목에 문맥 교정·제원표 복원·원문 조건부 용어 교정을 반영했습니다. DB 2,037개 파일, 4,110개 문단 위치 및 UI 90개 항목을 갱신했습니다.
- 짧은 시나리오 문구 783개와 심한 누락 후보 53개를 대조했습니다. 창작마당 팩 640개 시나리오를 조회 검사하고 누락 문구 53개를 추가했습니다.
- 공백 차이로 남아 있던 오래된 사전 키도 갱신했습니다. 문장 끝 구두점에 따른 UI 사전 우선순위 문제 4건을 수정했습니다.
- 2,392개 첫 호출 조회, 기존 자동 검사 60개 및 GDI/DirectWrite 검사를 통과했습니다. 전체 자연스러움 검수와 전 화면 실기 검증은 아직 미완료입니다.
- Inventoried 71,229 unique entries and addressed 2,388 through direct rewriting, table restoration and source-constrained terminology edits. Updated 4,110 paragraph positions across 2,037 DB files and 90 UI entries.
- Reviewed 783 short scenario strings and 53 severe-omission candidates; audited 640 workshop scenarios and added 53 missing lookup entries. Updated stale whitespace variants and resolved four punctuation-related glossary fallbacks.
- Passed 2,392 first-call lookup checks, the existing 60 automated checks and GDI/DirectWrite checks. Full manual coverage and all-screen visual verification remain incomplete.

## 2026-11-26 — 원문 해시 대조 기반 추가 검수

- 로컬 게임 원문을 SHA-256으로 대조하여 검수했습니다. 현재 추가 검수분은 14,329개 원문 항목입니다.
- 시나리오 사전 12,858개, UI 사전 179개, DB 4,324개 파일의 8,739개 문단을 갱신했습니다.
- 교전 금지·허가 조건, 군수·편제 용어, 함정·항공기 수량 및 누락된 제원을 문맥에 맞게 교정했습니다.
- 검수 항목 14,348개의 실제 번역 조회 함수 검사를 통과했습니다. 사전 키와 DB 문단 구조를 유지했습니다.
- 전체 직접 검수는 진행 중이며, 이 수치는 이번 추가 검수분만 나타냅니다. 이전 검수와의 중복을 제거한 전체 완료 건수는 아닙니다. 실제 게임 화면 검증은 수행하지 않았습니다.
- Restored source associations by hashing local game text and directly reviewed 14,329 source entries, rewriting where needed. All 14,348 runtime lookup checks passed. Full direct review remains incomplete.
- 시나리오의 정확한 번역을 일반 UI 번역보다 먼저 조회하도록 런타임을 수정했습니다. 날씨 문구 `Clear`가 UI의 ‘지우기’로 표시되던 문제를 재현하고, 수정 후 ‘맑음’으로 표시되는 조회 결과를 확인했습니다. UI의 ‘지우기’는 유지합니다. 재현 가능한 DLL 변경 스크립트는 `tools/fix-scenario-priority.py`에 있습니다.
- 별도 HTML 조각으로 분리된 영어 서수 접미사를 정리하고, 실제 원문 HTML 발췌 223개의 번역 결과에서 부대 번호 및 강조 구문이 자연스럽게 연결되는지 확인했습니다. 화면 렌더링 검증과는 별개인 HTML 변환 함수 검사입니다.
- 사전에서 여러 조각으로 나뉜 DB 원문도 문단 전체를 별도로 검수해 직접 적용합니다. 현재 별도 검수 원문은 503개 문단이며, 전체 원문 해시가 일치하는 1,468개 위치에 반영했습니다. 사전 검수 항목과 중복될 수 있어 합산하지 않습니다. 원문 문단 해시와 배포 파일의 적용 결과를 확인했습니다.
- 기존 사전에 없던 원문 19개를 게임 HTML 텍스트 노드 또는 원문 해시가 검증된 공백 정규화 표기와 대조해 별도 보충했습니다. 기존 사전 키는 모두 보존하며 보충 항목도 실제 번역 조회 검사에 포함합니다. 기존 항목 검수 수와 별도로 집계합니다.
- 설명·브리핑은 다체(~한다/~이다)로 통일하며 기존 검수분도 원문을 다시 대조해 수정한다. 문체 통일은 진행 중이다. README의 과거·최신 통계 중복을 정리하고 현재 검수 범위와 남은 작업을 명시했다.
- 공식 Codex SDK의 GPT-6 Astra(Medium)로 문단별 후보를 생성하고 모든 원문·번역문을 직접 대조한 후 반영하는 절차를 추가했다. 해시가 일치하는 전체 문단은 재사용하며, 숫자·URL·문체 검사로 검수 후보를 확인한다.
