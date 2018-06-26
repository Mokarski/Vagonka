namespace SDK.UI
{
    public struct MouseData
    {
        public int X;
        public int Y;
    }

    public struct BLEBeacon
    {
        public string Name;
        public int Rssi;
    }

    public struct KeyboardData
    {
        public int Keycode;

        public bool IsShift;
        public bool IsCtrl;
        public bool IsAlt;
        public bool IsMeta;
    }


    public struct MotionData
    {
        public int X;
        public int Y;
        public int Z;

        public MotionData(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, Z: {2}\t\t\t\t\r", X, Y, Z);
        }
    }
}
