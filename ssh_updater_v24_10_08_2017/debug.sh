#!/bin/sh
myll=`ps -A |grep Watchdog | cut -f 2 -d ' '`
kill $myll
killall mono
export MONO_PATH=/framework/lib/mono/4.0
export PATH=$PATH:/framework/bin











if [ ! -x /framework/bin/mono ]
then
    echo "No mono framework detected"
    exit 1
fi
if [ ! -x /mnt/software/bin/$FIRMWARE_EXE ]
then
    echo "No firmware found"
    exit 1
fi

if [ "$1" = "stop" -o "$1" = "restart" ]
then
    killall mono
    killall timesrv_arm
fi
if [ "$1" = "start" -o "$1" = "restart" ]
then
    echo Starting firmware
    echo $2
#    /usr/bin/timesrv_arm &
    cd /mnt/software/bin && LD_LIBRARY_PATH=/framework/lib mono $2 $3 
fi
