plink root@192.168.1.121 rm /mnt/software/ -r
plink root@192.168.1.121 mkdir /mnt/software
plink root@192.168.1.121 mkdir /mnt/software/bin

pscp "gateway\easymodbus.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\gateway.exe" root@192.168.1.121:/mnt/software/bin
pscp "gateway\journals.db" root@192.168.1.121:/mnt/software/bin
pscp "gateway\libsqlite3.so.0" root@192.168.1.121:/mnt/software/bin
pscp "gateway\libsqlite3.so.0.8.6" root@192.168.1.121:/mnt/software/bin
pscp "gateway\log4net.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\nini.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\protobuf-net.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\sdk.common.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\sdk.interfaces.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\sdk.networksservices.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\sdk.nmodbus.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\sdk.signalsfactory.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\sensors.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\sensors.pdb" root@192.168.1.121:/mnt/software/bin
pscp "gateway\signals.db" root@192.168.1.121:/mnt/software/bin
pscp "gateway\signals.dsc" root@192.168.1.121:/mnt/software/bin
pscp "gateway\signalsnamespace.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway\sqlite3.def" root@192.168.1.121:/mnt/software/bin
pscp "gateway\unme.common.dll" root@192.168.1.121:/mnt/software/bin

pscp "gateway\SDK.Watchdog.exe" root@192.168.1.121:/mnt/software/bin

plink root@192.168.1.121 chmod 775 * /mnt/software -R
plink root@192.168.1.121 sync
plink root@192.168.1.121 reboot
start.bat