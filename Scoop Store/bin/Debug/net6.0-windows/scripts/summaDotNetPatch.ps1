Set-ExecutionPolicy RemoteSigned -scope CurrentUser

Invoke-WebRequest -useb get.scoop.sh | Invoke-Expression

~\scoop\apps\scoop\current\bin\scoop.ps1 install git

~\scoop\apps\scoop\current\bin\scoop.ps1 bucket add dotnet-patch https://github.com/anderlli0053/DEV-tools 

~\scoop\apps\scoop\current\bin\scoop.ps1 install dotnet-runtime

cd ~\scoop\apps\scoop\current\bin\
.\scoop.ps1 bucket add extras
.\scoop.ps1 bucket add java 
.\scoop.ps1 bucket add a "https://github.com/ACooper81/Scoop-Apps.git" 

