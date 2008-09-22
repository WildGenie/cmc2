[Setup]
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{9FF72B3F-AD81-4E19-A86E-4BC75E6FC5C9}
AppName=CMC
AppVerName=CMC 2.6.24.920
AppPublisher=Peter Forman
DefaultDirName={pf}\CMC
DefaultGroupName=CMC
OutputDir="C:\DATA\dotnet projects\cmc\trunk\installer"
OutputBaseFilename=setup
SetupIconFile="C:\DATA\dotnet projects\cmc\trunk\CMC\Resources\files\cmc.ico"
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Dirs]
Name: "{app}\MyDir" ; Permissions: authusers-modify

[Files]
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\bin\cmc.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\bin\cmc.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\admgmt\bin\ADMgmt.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\perfmonitor\bin\Release\PerfMonitor.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\remoteregedit\bin\Release\RemReg.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\admgmt\bin\Interop.ActiveDs.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\admgmt\bin\Interop.TSUSEREXLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\perfmonitor\Resources\ZedGraph.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\netdetect\bin\Release\NetDetect.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\netlib\bin\Release\NetLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\Resources\files\psexec.exe"; DestDir: "{app}\Files"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\Resources\files\regx3.dll"; DestDir: "{app}\Files"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\Resources\files\vncviewer.exe"; DestDir: "{app}\Files"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\Resources\files\xzip.dll"; DestDir: "{app}\Files"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\Resources\files\netdom.exe"; DestDir: "{app}\Files"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\Resources\files\winvnc\winvnc4.exe"; DestDir: "{app}\Files\winvnc"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\Resources\files\winvnc\logmessages.dll"; DestDir: "{app}\Files\winvnc"; Flags: ignoreversion
Source: "C:\DATA\dotnet projects\cmc\trunk\CMC\Resources\files\winvnc\wm_hooks.dll"; DestDir: "{app}\Files\winvnc"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\CMC"; Filename: "{app}\cmc.exe";Comment: "Computer Management Console";Flags: UseAppPaths
Name: "{group}\AD User Manager"; Filename: "{app}\admgmt.exe"
Name: "{group}\Network Scanner (test)"; Filename: "{app}\netdetect.exe"
Name: "{group}\Remote RegEdit"; Filename: "{app}\remreg.exe"
Name: "{group}\Performance Monitor"; Filename: "{app}\perfmonitor.exe"
Name: "{group}\{cm:UninstallProgram,CMC}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\CMC"; Filename: "{app}\cmc.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\CMC"; Filename: "{app}\cmc.exe"; Tasks: quicklaunchicon

[Registry]
Root: HKCU; Subkey: "Software\Sysinternals\PsExec"; ValueType: dword; ValueName: "EulaAccepted"; ValueData: "1"

[Run]
Filename: "{app}\cmc.exe"; Description: "{cm:LaunchProgram,CMC}"; Flags: nowait postinstall skipifsilent

