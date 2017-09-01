plink root@192.168.1.122 cd /mnt/software/bin
pscp "debug.sh" root@192.168.1.122:/mnt/software/bin
plink root@192.168.1.122 chmod +x /mnt/software/bin/debug.sh

#plink root@192.168.1.122 /mnt/software/bin/debug.sh start --trace=E:all SDK.UI.Linux.exe

#plink root@192.168.1.122 /mnt/software/bin/debug.sh start --trace=N:SDK.NetworksServices SDK.UI.Linux.exe

#plink root@192.168.1.122 /mnt/software/bin/debug.sh start --trace=N:SDK.SignalsFactory SDK.UI.Linux.exe

#plink root@192.168.1.122 /mnt/software/bin/debug.sh start --trace=N:SDK.Interfaces SDK.UI.Linux.exe

#plink root@192.168.1.122 /mnt/software/bin/debug.sh start --trace=N:Sensors.B17K SDK.UI.Linux.exe

plink root@192.168.1.122 /mnt/software/bin/debug.sh start --verbose SDK.UI.Linux.exe




pause
#start.bat