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
