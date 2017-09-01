plink root@192.168.1.121 rm /mnt/software/ -r
plink root@192.168.1.121 mkdir /mnt/software
plink root@192.168.1.121 mkdir /mnt/software/bin

pscp "gateway_pchn\easymodbus.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\gateway.exe" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\journals.db" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\libsqlite3.so.0" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\libsqlite3.so.0.8.6" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\log4net.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\nini.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\protobuf-net.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\sdk.common.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\sdk.interfaces.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\sdk.networksservices.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\sdk.nmodbus.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\sdk.signalsfactory.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\sensors.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\sensors.pdb" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\signals.db" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\signals.dsc" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\signalsnamespace.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\sqlite3.def" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\unme.common.dll" root@192.168.1.121:/mnt/software/bin
pscp "gateway_pchn\SDK.Watchdog.exe" root@192.168.1.121:/mnt/software/bin

scp -r "gateway_pchn\" root@192.168.1.121:/mnt/software/bin/
plink root@192.168.1.121 chmod 775 * /mnt/software -R
plink root@192.168.1.121 sync
plink root@192.168.1.121 reboot
start.bat