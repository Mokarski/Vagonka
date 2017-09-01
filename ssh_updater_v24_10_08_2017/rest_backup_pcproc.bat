pscp.exe "backup_pcproc\*.*" root@192.168.1.121:/mnt/software/bin/
plink root@192.168.1.121 sync
plink root@192.168.1.121 reboot
start.bat