pscp "test_wagon" root@192.168.1.122:/mnt/software/bin
plink root@192.168.1.122 chmod +x /mnt/software/bin/test_wagon
plink root@192.168.1.122  /mnt/software/bin/test_wagon
pscp.exe root@192.168.1.122:panel43_wagon.log "pcproc_db\panel43_wagon.log"
start.bat