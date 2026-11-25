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
