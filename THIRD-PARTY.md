# 출처와 라이선스

- **Command: Modern Operations**: WarfareSims / Slitherine. 게임 원문 및 리소스의 권리는 각 권리자에게 있습니다. `payload`와 번역 사전에는 게임·커뮤니티 원문에 기반한 번역이 포함됩니다. 이 프로젝트가 해당 원문의 권리를 소유하거나 재배포 승인을 받았다고 주장하지 않습니다. 공개 전 해당 번역물의 배포 범위를 확인해야 합니다.
- **Harmony 2.4.3**: Andreas Pardeike, MIT. [공식 NuGet](https://www.nuget.org/packages/Lib.Harmony/2.4.3), 라이선스 전문은 `HARMONY-LICENSE.txt`. 설치 ZIP에 포함되며 소스 체크아웃에서는 다운로드 스크립트로 준비합니다.
- **Natural Earth**: public domain. [이용 조건](https://www.naturalearthdata.com/about/terms-of-use/). 지도 지명 데이터를 한국어로 변환했습니다.
- **GeoNames cities15000**: CC BY 4.0. [데이터 안내](https://download.geonames.org/export/dump/readme.txt), [라이선스](https://creativecommons.org/licenses/by/4.0/). 도시명과 좌표를 사용하고 한국어 표기를 교정·음차했습니다.
- **번역 초안 생성**: Meta NLLB-200 distilled 600M 및 mydubber-org의 CTranslate2 INT8 변환본을 로컬에서 사용했습니다. [원 모델](https://huggingface.co/facebook/nllb-200-distilled-600M), [변환본](https://huggingface.co/mydubber-org/nllb-200-distilled-600M-ct2-int8). 모델은 CC BY-NC 4.0이며 이 배포에는 모델·Python·번역 엔진을 포함하지 않습니다. 이 설명은 모델 라이선스를 번역 출력 전체에 자동 적용한다는 의미가 아닙니다.
- **DirectN / System.Numerics.Vectors**: 사용자의 게임 설치에 포함된 파일을 빌드·테스트 시 참조합니다. 배포하지 않습니다.

직접 작성한 코드에 적용할 공개 라이선스는 배포자가 선택해야 합니다. 현재 저장소에는 코드 전체를 대상으로 하는 MIT 등의 라이선스를 추가하지 않았습니다. 위 제3자 라이선스와 권리 표시는 그대로 유지해야 합니다.
