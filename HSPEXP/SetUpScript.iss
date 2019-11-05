; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "HSPEXP+"
#define MyAppVersion "3.1"
#define MyAppPublisher "RESPEC"
#define MyAppURL "http://www.respec.com/product/hspexp/"
#define MyAppExeName "HSPEXP+.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{07C3304A-C9A6-4D30-81C0-004F939FB8C1}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
AppContact= {#MyAppURL}
VersionInfoCopyright=Mozilla Public License (MPL) 1.1
DefaultDirName={reg:HKLM\SOFTWARE\RESPEC\BASINS45,Base Directory|{pf}\HSPEXP+}
DefaultGroupName={#MyAppName}
OutputBaseFilename=HSPEXP+3.1SetUp
Compression=lzma
SolidCompression=yes
InfoBeforeFile=install.txt

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Dev\BASINS\HSPEXP\bin\x86\Debug\HSPEXP+.exe"; DestDir: "{app}"; Permissions: everyone-modify; Flags: ignoreversion
Source: "C:\Dev\BASINS\HSPEXP\bin\x86\Debug\WinHSPFLt\*"; DestDir: "{app}\WinHSPFLt"; Permissions: everyone-modify; Flags: ignoreversion
Source: "C:\Dev\BASINS\HSPEXP\bin\x86\Debug\*.dll"; DestDir: "{app}"; Permissions: everyone-modify; Flags: ignoreversion
Source: "C:\Dev\BASINS\HSPEXP\*.pdf"; DestDir: "{app}"; Permissions: everyone-modify; Flags: ignoreversion
Source: "C:\Dev\BASINS\HSPEXP\GraphColors.txt"; DestDir: "{app}"; Permissions: everyone-modify; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversiono" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Dirs]
Name: {app}; Permissions: everyone-modify
Name: {app}\WinHSPFLt; Permissions: everyone-modify

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

