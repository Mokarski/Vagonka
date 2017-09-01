#Eth speed patch
cd /etc/rc.d
eths0='ethtool -s eth0 duplex half speed 10 autoneg off'
#echo $eths0 >> /etc/rc.d/rcS
echo 'ethtool -s eth0 duplex half speed 10 autoneg off' >> /etc/rc.d/init.d/firmware