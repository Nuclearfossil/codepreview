Code Preview in Explorer

Hey.
This is the first version of my Code Preview tool for Explorer (Windows 7 and up).

No fancy setup yet.  Just extract (or move) to your destination folder

To install the plugin.
   InstallCodePreview.bat

To uninstall the plugin, run
   UninstallCodePreview.bat

Additionally, you have to add your installation directory into your path. If you currently have an 
explorer window open, you will have to close it and re-open it again to get the preview functionality.

An installer will be coming along once the app is further developed

File types supported:
     --------------------------------------------------------------------------------
	|".c", ".h", ".cpp", ".hpp" | can be customized by the settings\cpp.xml file     |
	|".cs"                      | can be customized by the settings\cs.xml file      |
	|".py"                      | can be customized by the settings\python.xml file  |
	|".xml"                     | can be customized by the settings\xml.xml file     |
	|".bat", ".cmd"             | can be customized by the settings\batch.xml        |
     --------------------------------------------------------------------------------

This preview handler uses ScintillaNet as it's text rendering and lexing component.
Please refer to https://scintillanet.codeplex.com for more details.
This preview handler also uses SharpShell for Shell integration. Please refere to
https://www.nuget.org/packages/SharpShellTools/ for more details.
