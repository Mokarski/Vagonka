#Eth speed patch
cd /etc/rc.d
eths0='ethtool -s eth0 duplex half speed 10 autoneg off'
echo 'ethtool -s eth0 duplex half speed 10 autoneg off' >> /etc/rc.d/rc.conf
echo 'ethtool -s eth0 duplex half speed 10 autoneg off' >> /etc/rc.d/rcS