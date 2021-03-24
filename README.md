# Covid-19-Map-GIS
 Interactive country specific map for confirmed/death/recovered cases using visual studio & arcGIS.
 ## Features
 	a. Covid data visualization  for
		1. All country of the world	
		2. All district of Bangladesh
		3. All Thana of Dhaka Metropoliton area
	b. Different Map presentation
		1. Satellite view
		2. Street View
	c. Offline Maps
	
## Instructions:

	a.Visual Studio 2015 community edition.
	b. Bunifu Framework.
		Download Bunify Framework version 1.5.2 (https://www.dllme.com/dll/files/bunifu_ui_v1_52_dll.html)
		Open Visual Studio
		Load the project
		Open any form
		Go to toolbox on side pane
		Right click and click add tab and give a name
		Right click one the created tab and click choose items
		Click browse and find Bunifu 1.5.2 dll file
		Click ok.

	c. Map Server for Windows
		Download Map Server for Windows 4.0.4 (https://ms4w.com/release/ms4w_4.0.4.zip)
		Extract Folder on C:\\ drive
		Open CMD and run as administrator
		Change directory to C:\\ms4w\
		Type "apache-install.bat" and hit enter
		Open bowser and go to 127.0.0.1 to verify installation 

	d. MapWinGIS 
		Download MapWinGIS 5.0.1.1 (https://github.com/MapWindow/MapWinGIS/releases)
		Install MapWinGIS 5.0.1.1
		Open Visual Studio
		Load the project
		Open any form
		Go to toolbox on side pane
		Right click on any item and click choose items
		Select COM components
		Enable MapControl

	e. ArcGIS
		Download and install ArcGIS Desktop version 10.6 (https://desktop.arcgis.com/en/)
		Open ArcMap
		Click Add Data and open the shapefile 
	
	f. Shapefile.
		Download and place them on D:\ drive
	
	g. Offline Map data
		Download map_data and extract it all inside the following location
		‪C:\ms4w\Apache\htdocs

	h. Run 
		Open Visual Studio,
		Choose solution platform x86.
### Snapshots
![snap0](/screenshots/1.PNG)
![snap1](/screenshots/2.PNG)
![snap2](/screenshots/3.PNG)
![snap3](/screenshots/4.PNG)
![snap4](/screenshots/5.PNG)
