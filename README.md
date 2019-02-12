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
sudo cp dwm-net-statusbar /usr/local/bin
sudo cp dwm-net-statusbar.deps.json /usr/local/bin
sudo cp dwm-net-statusbar.dll /usr/local/bin
sudo cp dwm-net-statusbar.pdb /usr/local/bin
sudo cp dwm-net-statusbar.runtimeconfig.dev.json /usr/local/bin
sudo cp dwm-net-statusbar.runtimeconfig.json /usr/local/bin
sudo cp libhostfxr.so /usr/local/bin
sudo cp libhostpolicy.so /usr/local/bin
```