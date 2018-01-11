namespace SDK.UI.Style.WSVGA.Sparc
{
    public static class ColorLegend
    {
        private static readonly uint[] Colors = new uint[]
                                                    {
                                                        //0x8b8d8fff,
                                                        0x2b6d94ff,
                                                        0x2b6d94ff,
                                                        0x1a7bb3ff,
                                                        0x1f86a4ff,
                                                        0x249093ff,
                                                        0x2ba07eff,
                                                        0x31ad6bff,
                                                        0x39be52ff,
                                                        0x3fcc3fff,
                                                        0x44d72fff,
                                                        0x49e023ff, // index 10 - normal
                                                        0xa4e022ff,
                                                        0xb8dc23ff,
                                                        0xd0d725ff,
                                                        0xe7d227ff,
                                                        0xf2d027ff,
                                                        0xf2de1eff,
                                                        0xf26413ff,
                                                        0xf22d08ff,
                                                        0xf20000ff // index 19
                                                    };


        public static ushort Max { get; set; }
        public static ushort Normal { get; set; }

        public static uint GetColor(ushort data)
        {
            int index;
            if (data <= Normal)
            {
                index = (int)(data * (11.0f / Normal));
            }
            else
            {
                index = 11 + (int)((data - Normal) * (9.0f / (Max - Normal))); // 9 - from normal to max
            }

            if (index > Colors.Length - 1)
                index = Colors.Length - 1;

            return Colors[index];
        }
    }
}