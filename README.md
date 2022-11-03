#Een front-in voor de [Scoop Package Manager](https://github.com/ScoopInstaller/Scoop)


### App aanvragen?
	Mail aub naar PS226168@edu.summacollege.nl


### App Index
* Spotify
* Steam
* Windows Terminal
* Firefox

### Installeer
```
iwr -uri https://github.com/jayverrijt/ScoopStore/releases/download/stable-release/v1.1.1.zip -OutFile '.\ScoopStore-v1.1.1.zip'
```

#### Installeer voor Summa
```
iwr -uri https://github.com/jayverrijt/ScoopStore/releases/download/stable-release/v1.1.1.zip -OutFile '.\ScoopStore-v1.1.1.zip'

Set-ExecutionPolicy RemoteSigned -scope CurrentUser
.\scripts\summaDotNetPatch.ps1
```
