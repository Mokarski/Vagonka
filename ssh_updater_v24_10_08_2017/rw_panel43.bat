plink root@192.168.1.122 rm /mnt/software/ -r
plink root@192.168.1.122 mkdir /mnt/software
plink root@192.168.1.122 mkdir /mnt/software/bin
plink root@192.168.1.122 mkdir /mnt/software/bin/resources

pscp "panel43\sensors.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\log4net.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\nini.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\protobuf-net.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\readme.txt" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.common.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.interfaces.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.networksservices.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.nmodbus.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.prospero.hardware.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.signalsfactory.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.ui.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.ui.linux.exe" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.ui.smartapp.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.ui.smartapp_old.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.ui.style.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sdk.watchdog.exe" root@192.168.1.122:/mnt/software/bin
pscp "panel43\sensors.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\test_wagon" root@192.168.1.122:/mnt/software/bin
pscp "panel43\timecl_arm" root@192.168.1.122:/mnt/software/bin
pscp "panel43\unme.common.dll" root@192.168.1.122:/mnt/software/bin
pscp "panel43\resources\wvga.filter.raw" root@192.168.1.122:/mnt/software/bin/resources
pscp "panel43\resources\wvga.infoicon.bg.raw" root@192.168.1.122:/mnt/software/bin/resources
pscp "panel43\resources\wvga.infoicon.fg.raw" root@192.168.1.122:/mnt/software/bin/resources
pscp "panel43\resources\wvga.roll_tangage.raw" root@192.168.1.122:/mnt/software/bin/resources
pscp "panel43\resources\wvga.vagon.raw" root@192.168.1.122:/mnt/software/bin/resources
pscp "panel43\resources\wvga_logo.raw" root@192.168.1.122:/mnt/software/bin/resources
pscp "panel43\resources\wvga_view1.raw" root@192.168.1.122:/mnt/software/bin/resources
pscp "panel43\resources\wvga_view2.raw" root@192.168.1.122:/mnt/software/bin/resources
pscp "panel43\resources\wvga_view2_background.raw" root@192.168.1.122:/mnt/software/bin/resources

plink root@192.168.1.122 chmod 775 * /mnt/software -R
plink root@192.168.1.122 sync
plink root@192.168.1.122 reboot
start.bat