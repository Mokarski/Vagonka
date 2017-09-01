plink root@192.168.1.121 cd /mnt/software/bin
pscp "debug.sh" root@192.168.1.121:/mnt/software/bin
plink root@192.168.1.121 chmod +x /mnt/software/bin/debug.sh

#plink root@192.168.1.121 /mnt/software/bin/debug.sh start --trace=E:all Gateway.exe

#plink root@192.168.1.121 /mnt/software/bin/debug.sh start --trace=N:SDK.NetworksServices Gateway.exe

plink root@192.168.1.121 /mnt/software/bin/debug.sh start --trace=N:SDK.SignalsFactory Gateway.exe

#plink root@192.168.1.121 /mnt/software/bin/debug.sh start --trace=N:SDK.Interfaces Gateway.exe

#plink root@192.168.1.121 /mnt/software/bin/debug.sh start --trace=N:Sensors.B17K Gateway.exe

#plink root@192.168.1.121 /mnt/software/bin/debug.sh start --verbose Gateway.exe




pause
#start.bat