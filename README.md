# dwm status bar .net core
Tested on MBA2013 Arch Linux
## Features
- Battery percentage and charging state (/sys/class/power_supply/BAT0)
- Local IP address and connection state
- Time

## publish
```sh
dotnet publish -c Release --self-contained true --runtime linux-x64 --framework netcoreapp2.2
dotnet publish -c Release -r linux-x64 --self-contained false
```

```sh
sudo mkdir /usr/local/bin/dwm-status
sudo cp bin/Release/netcoreapp2.2/linux-x64/* /usr/local/bin/dwm-status

```