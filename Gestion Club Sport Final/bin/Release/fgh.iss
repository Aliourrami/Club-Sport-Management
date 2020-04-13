; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{EE10E88A-93F1-47FB-8CC5-F0F1823F49BF}
AppName=Gestion Club Sport Beta
AppVersion=1.5
;AppVerName=Gestion Club Sport Beta 1.5
AppPublisher=My Company, Inc.
AppPublisherURL=http://www.example.com/
AppSupportURL=http://www.example.com/
AppUpdatesURL=http://www.example.com/
DefaultDirName={pf}\Gestion Club Sport Beta
DisableProgramGroupPage=yes
OutputDir=C:\Users\Ali\Desktop\New folder
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\Gestion Club Sport Final.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\Bunifu_UI_v1.52.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.CrystalReports.Engine.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.ClientDoc.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.CommLayer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.CommonControls.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.CommonObjectModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.Controllers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.CubeDefModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.DataDefModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.DataSetConversion.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.ObjectFactory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.Prompting.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.ReportDefModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportAppServer.XmlSerialize.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.ReportSource.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.Shared.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\CrystalDecisions.Windows.Forms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\EntityFramework.SqlServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\FlashControlV71.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\Gestion Club Sport Final.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\Gestion Club Sport Final.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\ShockwaveFlashObjects.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ali\source\repos\Gestion Club Sport Final\Gestion Club Sport Final\bin\Release\stdole.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\Gestion Club Sport Beta"; Filename: "{app}\Gestion Club Sport Final.exe"
Name: "{commondesktop}\Gestion Club Sport Beta"; Filename: "{app}\Gestion Club Sport Final.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Gestion Club Sport Final.exe"; Description: "{cm:LaunchProgram,Gestion Club Sport Beta}"; Flags: nowait postinstall skipifsilent

