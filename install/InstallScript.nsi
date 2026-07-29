
SetCompressor /FINAL /SOLID lzma


#기본내용 설정==============================================================
!define PRODUCT_NAME        "WinStatusBoard"        ;프로그램 이름
!define PRODUCT_KOREAN_NAME "종합현황판"            ;프로그램 한글 이름
!define PRODUCT_VERSION     ${VERSION}              ;프로그램 버전
!define PRODUCT_PUBLISHER   "DT Korea"              ;회사명
!define PRODUCT_EXE_NAME    "FrmWinStatus"          ;설치 완료후 실행될 실행 파일 이름
!define PRODUCT_DIR_REGKEY  "Software\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_EXE_NAME}.exe"
!define PRODUCT_UNINST_KEY  "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"              ; 설치정보를 저장할 위치를 지정 - HKLM 혹은 HKCU
!define PRODUCT_PROJECT_FOLDER  "project"           ; 빌드완료된 파일들이 옮겨진 폴더명
!define PRODUCT_SETUPFILE_FOLDER "setupfile"        ; 빌드완료 후 설치파일이 저장될 폴더명


# include 설정==============================================================
!include "MUI.nsh"
!include "x64.nsh"


# MUI 기본 설정==============================================================
!define MUI_ABORTWARNING                                                         ; 설치 취소시 경고 메시지 뿌리기
!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\modern-install.ico"          ; 설치 아이콘
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"      ; 삭제 아이콘
!define MUI_FINISHPAGE_RUN "$INSTDIR\${PRODUCT_EXE_NAME}.exe"                    ; 종료후 프로그램 자동 실행 여부 물어 보기


# MUI 페이지 설정==============================================================
!insertmacro MUI_PAGE_WELCOME                                              ; 시작 환영 페이지
!insertmacro MUI_PAGE_DIRECTORY                                            ; 디렉토리 선택 페이지
!insertmacro MUI_PAGE_INSTFILES                                            ; 설치중
!insertmacro MUI_PAGE_FINISH                                               ; 종료 페이지 보이기
!insertmacro MUI_UNPAGE_INSTFILES                                          ; 파일 삭제 진행 상황 페이지
!insertmacro MUI_LANGUAGE "Korean"                                         ; 언어 설정
!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS

# NSIS 기본 설정==============================================================
Name                  "${PRODUCT_NAME} ${PRODUCT_VERSION}"                    ; 기본 이름
OutFile               "${PRODUCT_SETUPFILE_FOLDER}\${PRODUCT_NAME}Setup_v${PRODUCT_VERSION}.exe"   ; 컴파일 후 생성될 설치 파일명
InstallDir            "$PROGRAMFILES\${PRODUCT_PUBLISHER}\${PRODUCT_NAME}"    ; 프로그램이 설치될 경로
InstallDirRegKey      HKLM "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails       show                                                    ; 설치내용 자세히 보기 여부(hide|show|nevershow)
ShowUnInstDetails     show                                                    ; 언인스톨 자세히 보기 여부(hide|show|nevershow)
SetOverwrite          on                                                      ; 파일 복사시 기본적으로 덮어쓰기 한다(디폴트) (on|off|try|ifnewer)



# 설치 모드==============================================================
Section "MainSection" SEC01

  ; 파일 복사
  SetOutPath "$INSTDIR"
  File /r "${PRODUCT_PROJECT_FOLDER}\*"
  
  CreateDirectory "$SMPROGRAMS\${PRODUCT_NAME}"                                                                 ;프로그램 그룹 만들기
  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_KOREAN_NAME}.lnk" "$INSTDIR\${PRODUCT_EXE_NAME}.exe"    ;프로그램 그룹 바로가기 만들기
  CreateShortCut "$DESKTOP\${PRODUCT_KOREAN_NAME}.lnk" "$INSTDIR\${PRODUCT_EXE_NAME}.exe"                       ;바탕화면 바로가기 만들기
  
  Call CheckAndInstallDotNet ; 닷넷 설치 확인
SectionEnd

Section -AdditionalIcons
  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  #삭제 파일 생성
  WriteUninstaller "$INSTDIR\uninst.exe"
  
  # 삭제 정보 레지스트리 등록(제어판 프로그램 추가제거에 나타낼 정보)
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\${PRODUCT_EXE_NAME}.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\${PRODUCT_EXE_NAME}.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd

# 삭제 완료후 나타나는 메시지  =======================================
Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name)는(은) 완전히 제거되었습니다."
FunctionEnd

# 삭제 전 나타나는 메시지  ===========================================
Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "$(^Name)을(를) 제거하시겠습니까?" IDYES +2
  Abort
FunctionEnd


# 삭제 모드 ==============================================================
Section Uninstall
  Delete "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk"                 ; 삭제 바로가기 삭제
  Delete "$DESKTOP\${PRODUCT_KOREAN_NAME}.lnk"                       ; 바탕화면 바로가기 삭제
  Delete "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_KOREAN_NAME}.lnk"    ; 시작메뉴 삭제
  Delete "$DESKTOP\${PRODUCT_NAME}.lnk"                              ; 바탕화면 바로가기 삭제
  Delete "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk"           ; 시작메뉴 삭제

  RMDir "$SMPROGRAMS\${PRODUCT_NAME}"                                ; 시작메뉴 지우기
  RMDir /r "$INSTDIR"                                                ; 파일 전체 지우기

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"    ; 실행파일 등록 삭제
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"                          ; 설치 위치 및 APP 정보 삭제
  
  SetAutoClose true
SectionEnd


# 닷넷 버전 확인 및 설치 ==============================================================
!define NETVersionDWORD 528040 # .NET Framework 4.8
!define NETVersion "4.8"

Function CheckAndInstallDotNet 
  # 닷넷 버전 레지스트리 값 확인 참조
  # https://docs.microsoft.com/ko-kr/dotnet/framework/migration-guide/how-to-determine-which-versions-are-installed
  # .NET Framework 4.8
  # Windows 10 2019년 5월 업데이트 및 Windows 10 2019년 11월 업데이트: 528040
  # Windows 10 2020년 5월 업데이트, Windows 10 2020년 10월 업데이트, Windows 10 2021년 5월 업데이트: 528372
  # Windows 11 및 Windows Server 2022: 528449
  # 다른 모든 Windows 운영 체제(다른 Windows 10 운영 체제 포함): 528049
  # 넷중 작은 숫자로 비교하면 된다

  ClearErrors
  ReadRegDWORD $0 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" "Release"

  IfErrors NotDetected

    ${If} $0 >= ${NETVersionDWORD}
        DetailPrint "Microsoft .NET Framework ${NETVersion} is installed ($0)"
    ${Else}
    NotDetected:
        DetailPrint "Microsoft .NET Framework ${NETVersion} is not installed"

        MessageBox MB_YESNO "Do you want to install Microsoft .NET Framework ${NETVersion}?" IDYES true IDNO false
        true: # YES시 닷넷프레임워크 설치후 계속 진행
          DetailPrint "Installing Microsoft .NET Framework ${NETVersion}"
          SetDetailsPrint listonly
          ExecWait '"$INSTDIR\Setup\NDP472-KB4054530-x86-x64-AllOS-ENU.exe" /passive /norestart' $0
          ${If} $0 == 3010
          ${OrIf} $0 == 1641
              DetailPrint "Microsoft .NET Framework ${NETVersion} installer requested reboot"
              SetRebootFlag true
          ${EndIf}
          SetDetailsPrint lastused
          DetailPrint "Microsoft .NET Framework ${NETVersion} installer returned $0"
        false: # NO시 설치안하고 계속 진행
          DetailPrint "Continue without .NET Framework ${NETVersion} installation"
          # Abort # 설치 취소할 경우 Abort
    ${EndIf}

FunctionEnd