echo off 
echo %1
echo %nowdate%
plink root@192.168.1.121 date '-s "%nowdate%"'
plink root@192.168.1.121 hwclock -w 

plink root@192.168.1.122 date '-s "%nowdate%"'
plink root@192.168.1.122 hwclock -w 
pause
start.bat