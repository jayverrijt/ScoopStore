Invoke-WebRequest -useb get.scoop.sh | Invoke-Expression

Set-ExecutionPolicy RemoteSigned -scope CurrentUser
~\scoop\apps\scoop\current\bin\scoop.ps1 install git
