pscp.exe  "backup_panel43\*.*" root@192.168.1.122:/mnt/software/bin/
plink root@192.168.1.122 sync
plink root@192.168.1.122 reboot
start.bat