plink root@192.168.1.121 killall mono

plink root@192.168.1.121 cd /mnt/software/bin

plink root@192.168.1.121 cp /dev/null  /mnt/software/bin/signals.db
plink root@192.168.1.121 cp /dev/null  /mnt/software/bin/journals.db

plink root@192.168.1.121 chmod 775 /mnt/software/bin/signals.db
plink root@192.168.1.121 chmod 775 /mnt/software/bin/journals.db

plink root@192.168.1.121 ls -l 
#plink root@192.168.1.121 sync 
#plink root@192.168.1.121 reboot

start.bat