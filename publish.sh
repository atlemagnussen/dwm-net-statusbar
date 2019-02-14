#!/bin/bash
dotnet publish -c Release --self-contained true --runtime linux-x64 --framework netcoreapp2.2
sudo cp bin/Release/netcoreapp2.2/linux-x64/* /usr/local/bin/dwm-status
