Set-ExecutionPolicy RemoteSigned -scope CurrentUser
cd ~\scoop\apps\scoop\current\bin\
.\scoop.ps1 bucket add extras
.\scoop.ps1 bucket add java 
.\scoop.ps1 bucket add a "https://github.com/ACooper81/Scoop-Apps.git" 