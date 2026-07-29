## 개발환경
+ VisualStudio 2017 - .NET4.8 (.NET 데스크톱 개발) 
+ DevExpress 19.1
+ NSIS (사이트 : https://nsis.sourceforge.io/Download )

### Git Clone
```bash
    git clone https://github.com/lyself23/WinStatusBoard.git
```

<br><br>

## 기본 구조
1. DataBaseInfo
   - DB접속 정보 및 쿼리조회 dll
   - 각 Frm화면명 프로젝트에 참조추가가 되어있어야함

2. Frm화면명 
   - dll 프로젝트
   - 최초에는 윈폼으로 생성
   - DBSQL 프로젝트 추가 방법
     ![그림1](https://user-images.githubusercontent.com/67846924/145222212-f64479e8-baca-4bab-a59c-7572863d63f1.png)
   - 테스트동안에는 프로젝트 출력형식을 Windows 애플리케이션, FrmMain에 추가할 때는 클래스 라이브러리로 변경하여 빌드 
     ![그림1](https://user-images.githubusercontent.com/67846924/145225559-455a9c63-ab5a-47d5-a6a4-6c89b3a8b9f3.png)
   - 원하는 프로젝트 시작프로젝트로 변경 후 디버그 실행
     ![그림2](https://user-images.githubusercontent.com/67846924/145226164-b64630e0-7be7-4f49-9ff7-865eed78d7be.png)

3. Frm화면 속 화면
   - UserControl 생성

4. FrmWinStatus
   - .exe 프로젝트
   - 각 화면으로 이동하기 위한 프로젝트
 
<br><br>

## 설치파일 만들기 (NSIS 설치 필수)
1. Release 모드로 빌드 진행
   - ![image](https://user-images.githubusercontent.com/67846924/172003768-d94d915c-e151-42a4-8ebd-9b7f35787365.png)

2. 빌드 완료 후 설치파일 및 패치파일 생성
   - WinStatusBoard\install\setupfile 폴더에 생성
   - 설치용은 설치 화면 보여줌, 패치용은 설치 진행률만 보여주고 자동 실행
   - 설치용 : WinStatusBoardSetup_v${Version}.exe
   - 패치용 : WinStatusBoardPatch_v${Version}.exe
   - ![image](https://user-images.githubusercontent.com/67846924/172003930-357c2cf7-d800-433f-ae2d-e55608bb9261.png)


