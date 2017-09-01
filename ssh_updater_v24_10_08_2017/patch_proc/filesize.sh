#!/bin/sh
size=$( df|grep ubi0 | cut -f 27 -d ' ' | cut -f 1 -d "%")
echo $size
du /mnt/software/bin/journals.db

if [ $size -gt 85 ]; then
echo "file system full"
cp /dev/null /mnt/software/bin/journals.db
du /mnt/software/bin/journals.db
fi

 
