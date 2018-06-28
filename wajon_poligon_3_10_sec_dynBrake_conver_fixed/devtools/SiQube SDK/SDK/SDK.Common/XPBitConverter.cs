using System;
using System.Collections.Generic;

namespace SDK.Common
{   
    public static class XpBitConverter
    {
        public static byte[] GetBytes(float value)
        {
            #if !MONO
                return BitConverter.GetBytes(value);
            #else
                return DataConverter.GetBytes(value);
            #endif
        }
        
        public static byte[] GetBytes(uint value)
        {
            #if !MONO
                return BitConverter.GetBytes(value);
            #else
                return DataConverter.GetBytes(value);
            #endif
        }

        public static byte[] GetBytes(UInt16 value)
        {
            #if !MONO
                return BitConverter.GetBytes(value);
            #else
                return DataConverter.GetBytes(value);
            #endif
        }

        public static byte[] GetBytes(Int16 value)
        {
            #if !MONO
                return BitConverter.GetBytes(value);
            #else
                return DataConverter.GetBytes(value);
            #endif
        }

        public static byte[] GetBytes(Int32 value)
        {
            #if !MONO
                return BitConverter.GetBytes(value);
            #else
                return DataConverter.GetBytes(value);
            #endif  
        }

        public static byte[] GetBytes(uint [] values)
        {
            var result = new List<byte>();

            foreach (var t in values)
                result.AddRange(GetBytes(t));

            return result.ToArray();
        }

        public static byte[] GetBytes(ushort[] values)
        {
            var result = new List<byte>();

            foreach (var t in values)
                result.AddRange(GetBytes(t));

            return result.ToArray();
        }

        public static UInt16[] GetUint16(byte[] values)
        {
            var result = new List<UInt16>();

            for (var i = 0; i < values.Length/2; i++)
            {
                result.Add((ushort) (values[2*i] | (values[2*i + 1] << 8)));
            }

            return result.ToArray();
        }

        public static Int32[] GetInt(byte[] values)
        {
            var result = new List<Int32>();

            for (var i = 0; i < values.Length / 4; i++)
            {
                result.Add(values[4 * i] | (values[4 * i + 1] << 8) | values[4 * i  + 2] << 16 | (values[4 * i + 3] << 24));
            }

            return result.ToArray();
        }


        public static float[] GetSingle(byte[] values)
        {
            var result = new List<float>();

            for (var i = 0; i < values.Length / 4; i++)
            {
#if !MONO
                var rv = BitConverter.ToSingle(values, i*4);
#else
                var rv = DataConverter.GetFloat(values, i*4);
#endif
                result.Add(rv);
            }

            return result.ToArray();            
        }

        public static long ToLong(byte[] value, int startIndex)
        {
            long rv = 0;

            const byte kNativeSize = 8;
            for (byte i = 0; i < kNativeSize; i++)
            {
                rv |= value[startIndex + i];
                if ((i + 1) < kNativeSize)
                    rv <<= 8;
            }

            return rv;
        }

        public static bool ToBoolean(byte[] value, int startIndex)
        {
            if (value[startIndex] > 0)
                return true;

            return false;
        }

        public static UInt16 ToUint16(byte[] value, int startIndex)
        {
            UInt16 rv = 0;

            const byte kNativeSize = 2;
            for (byte i = kNativeSize - 1; i > 0; i--)
            {
                rv |= value[startIndex + i];
                rv <<= 8;
            }

            rv |= value[startIndex];

            return rv;
        }

        public static UInt32 ToUint32(byte[] value, int startIndex)
        {
            UInt32 rv = 0;

            const byte kNativeSize = 4;
            for (byte i = kNativeSize - 1; i > 0; i--)
            {
                rv |= value[startIndex + i];
                rv <<= 8;
            }

            rv |= value[startIndex];

            return rv;
        }

        public static Int32 ToInt32(byte[] value, int startIndex)
        {
            Int32 rv = 0;

            const byte kNativeSize = 4;
            for (byte i = kNativeSize - 1; i > 0; i--)
            {
                rv |= value[startIndex + i];
                rv <<= 8;
            }

            rv |= value[startIndex];

            return rv;
        }
    }
}
