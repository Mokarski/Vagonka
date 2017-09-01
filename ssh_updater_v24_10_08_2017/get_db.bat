pscp.exe root@192.168.1.121:/mnt/software/bin/signals.db "pcproc_db\signals.db"
pscp.exe root@192.168.1.121:/mnt/software/bin/journals.db "pcproc_db\journals.db"
pscp.exe root@192.168.1.122:panel43_wagon.log "pcproc_db\panel43_wagon.log"
pscp.exe root@192.168.1.121:pcproc_wagon.log "pcproc_db\pcproc_wagon.log"
start.bat