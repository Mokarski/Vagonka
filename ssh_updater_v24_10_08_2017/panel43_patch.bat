plink root@192.168.1.122 cd /etc/rc.d
#pscp "patch_panel43\speed10.sh" root@192.168.1.122:/etc/rc.d
pscp "patch_panel43\firmware" root@192.168.1.122:/etc/rc.d/init.d/firmware
#pscp "root@192.168.1.122:/etc/rc.d/init.d/firmware" patch_panel43\firmware

#plink root@192.168.1.122 chmod 775 /etc/rc.d/speed10.sh
#plink root@192.168.1.122 /etc/rc.d/speed10.sh

plink root@192.168.1.122 sync 
plink root@192.168.1.122 reboot
start.bat