set current_dir=%~dp0

FOR /F "USEBACKQ" %%F IN (`powershell -NoLogo -NoProfile -Command ^(Get-Item "%current_dir%\project\FrmWinStatus.exe"^).VersionInfo.FileVersion`) DO (SET fileVersion=%%F)

"%ProgramFiles(x86)%\NSIS\makensis.exe" /DVERSION=%fileVersion% %current_dir%\InstallScript.nsi

rem pause