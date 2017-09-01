plink root@192.168.1.121 cd /etc/rc.d
pscp "patch_proc\speed10.sh" root@192.168.1.121:/etc/rc.d
pscp "patch_proc\filesize.sh" root@192.168.1.121:/etc/rc.d
pscp "patch_proc\filesize2.sh" root@192.168.1.121:/etc/rc.d

plink root@192.168.1.121 chmod 775 /etc/rc.d/speed10.sh
plink root@192.168.1.121 /etc/rc.d/speed10.sh

plink root@192.168.1.121 chmod 775 /etc/rc.d/filesize2.sh
plink root@192.168.1.121 /etc/rc.d/filesize2.sh

plink root@192.168.1.121 sync 
plink root@192.168.1.121 reboot

start.bat