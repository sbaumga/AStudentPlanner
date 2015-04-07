; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{9FD5BFBB-FEA6-47DC-984D-9996F21D2E4A}
AppName=A+ Student Planner
AppVerName=A+ Student Planner 1.1
AppPublisher=David Riggleman
AppPublisherURL=http://www.davidriggleman.org
AppSupportURL=http://www.davidriggleman.org
AppUpdatesURL=http://www.davidriggleman.org
DefaultDirName={pf}\A+ Student Planner
DefaultGroupName=A+ Student Planner
OutputBaseFilename=a+_student_planner_setup
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin
AlwaysRestart=no
ChangesAssociations=no
UsePreviousAppDir=no

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: ".\Release\Calendar.DayView.dll"; DestDir: "{app}"; 
Source: ".\Release\Calendar.exe"; DestDir: "{app}"; 
Source: ".\Release\Calendar.exe.config"; DestDir: "{app}"; 
Source: ".\Release\Calendar.exe.manifest"; DestDir: "{app}"; 
Source: ".\Release\Google.GData.AccessControl.dll"; DestDir: "{app}"; 
Source: ".\Release\Google.GData.Calendar.dll"; DestDir: "{app}"; 
Source: ".\Release\Google.GData.Client.dll"; DestDir: "{app}"; 
Source: ".\Release\Google.GData.Extensions.dll"; DestDir: "{app}"; 
Source: ".\..\pencil.ico"; DestDir: "{app}"; 
Source: ".\Release\System.Data.SQLite.dll"; DestDir: "{app}"; 
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\A+ Student Planner"; Filename: "{app}\Calendar.exe"; WorkingDir: "{app}"
Name: "{group}\Uninstall A+ Student Planner"; Filename: "{uninstallexe}"
Name: "{commondesktop}\A+ Student Planner"; Filename: "{app}\Calendar.exe"; WorkingDir: "{app}"; Tasks: desktopicon

[Run]
Filename: "{app}\Calendar.exe"; Description: "{cm:LaunchProgram,A+ Student Planner}"; Flags: nowait postinstall skipifsilent
