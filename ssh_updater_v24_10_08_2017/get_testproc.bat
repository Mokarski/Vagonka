#plink root@192.168.1.121 mkdir /mnt/software
#pscp.exe root@192.168.1.121:pcproc_wagon.log "pcproc_db\pcproc_wagon.log"

pscp "test_wagon" root@192.168.1.121:/mnt/software/bin
plink root@192.168.1.121 chmod +x /mnt/software/bin/test_wagon

plink root@192.168.1.121  /mnt/software/bin/test_wagon
pscp.exe root@192.168.1.121:pcproc_wagon.log "pcproc_db\pcproc_wagon.log"
start.bat