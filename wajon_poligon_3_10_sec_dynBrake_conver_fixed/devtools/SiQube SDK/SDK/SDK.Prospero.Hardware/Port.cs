using System;
using System.IO;
using System.Linq;

namespace SDK.Prospero.Hardware
{
    public class Port : IDisposable
    {
        protected Port(Pin portId)
        {
            Id = portId;
        }

        internal void Init()
        {
            const string kUrl = @"/sys/class/gpio/export";
            if (File.Exists(kUrl))
                File.WriteAllText(kUrl, ParsePin(Id).ToString(""));
            else
            {
                Console.WriteLine("support /sys/class/gpio disabled in linux kernel");
            }
        }

        public bool Read()
        {
            var url = @"/sys/class/gpio/gpio" + ParsePin(Id) + "/value";
            if(File.Exists(url))
                return !File.ReadAllText(url).Contains("0");

            return false;
        }

        public Pin Id { get; private set; }

        public void Dispose()
        {
            Console.WriteLine("port dispose");

            const string kUrl = @"/sys/class/gpio/unexport";
            if (File.Exists(kUrl))
                File.WriteAllText(kUrl, ParsePin(Id).ToString(""));
        }

        protected int ParsePin(Pin id)
        {
            return Enum.GetNames(typeof (Pin)).ToList().IndexOf(Enum.GetName(typeof(Pin), Id));
        }
    }

    public class OutputPort : Port
    {
        public OutputPort(Pin portId, bool initialState) : base(portId)
        {
            var url = @"/sys/class/gpio/gpio" + ParsePin(Id) + "/direction";
            if (!File.Exists(url))
                Init();
            
            if (!File.Exists(url))
                Console.WriteLine("port {0} unavailable", url);
            else
            {
                File.WriteAllText(url, "out");
                Write(initialState);   
            }            
        }

        public void Write (bool state)
        {
            var url = @"/sys/class/gpio/gpio" + ParsePin(Id) + "/value";
            if (!File.Exists(url)) return;

            File.WriteAllText(url, state ? "1" : "0");
        }
    }

    public class InputPort : Port
    {
        public InputPort(Pin portId) : base(portId)
        {
            var url = @"/sys/class/gpio/gpio" + ParsePin(Id) + "/direction";
            if (!File.Exists(url))
                Init();
            
            if (!File.Exists(url))
                Console.WriteLine("port {0} unavailable", url);
            else
            {
                File.WriteAllText(url, "in");
            }     
        }
    }

    public enum Pin
    {
        Gpio0_0 = 0,
        Gpio0_1 = 1,
        Gpio0_2,
        Gpio0_3,
        Gpio0_4,
        Gpio0_5,
        Gpio0_6,
        Gpio0_7,
        Gpio0_8,
        Gpio0_9,
        Gpio0_10,
        Gpio0_11,
        Gpio0_12,
        Gpio0_13,
        Gpio0_14,
        Gpio0_15,
        Gpio0_16,
        Gpio0_17,
        Gpio0_18,
        Gpio0_19,
        Gpio0_20,
        Gpio0_21,
        Gpio0_22,
        Gpio0_23,
        Gpio0_24,
        Gpio0_25,
        Gpio0_26,
        Gpio0_27,
        Gpio0_28,
        Gpio0_29,
        Gpio0_30,
        Gpio0_31,
        Gpio1_0,
        Gpio1_1,
        Gpio1_2,
        Gpio1_3,
        Gpio1_4,
        Gpio1_5,
        Gpio1_6,
        Gpio1_7,
        Gpio1_8,
        Gpio1_9,
        Gpio1_10,
        Gpio1_11,
        Gpio1_12,
        Gpio1_13,
        Gpio1_14,
        Gpio1_15,
        Gpio1_16,
        Gpio1_17,
        Gpio1_18,
        Gpio1_19,
        Gpio1_20,
        Gpio1_21,
        Gpio1_22,
        Gpio1_23,
        Gpio1_24,
        Gpio1_25,
        Gpio1_26,
        Gpio1_27,
        Gpio1_28,
        Gpio1_29,
        Gpio1_30,
        Gpio1_31,
        Gpio2_0,
        Gpio2_1,
        Gpio2_2,
        Gpio2_3,
        Gpio2_4,
        Gpio2_5,
        Gpio2_6,
        Gpio2_7,
        Gpio2_8,
        Gpio2_9,
        Gpio2_10,
        Gpio2_11,
        Gpio2_12,
        Gpio2_13,
        Gpio2_14,
        Gpio2_15,
        Gpio2_16,
        Gpio2_17,
        Gpio2_18,
        Gpio2_19,
        Gpio2_20,
        Gpio2_21,
        Gpio2_22,
        Gpio2_23,
        Gpio2_24,
        Gpio2_25,
        Gpio2_26,
        Gpio2_27,
        Gpio2_28,
        Gpio2_29,
        Gpio2_30,
        Gpio2_31,
        Gpio3_0,
        Gpio3_1,
        Gpio3_2,
        Gpio3_3,
        Gpio3_4,
        Gpio3_5,
        Gpio3_6,
        Gpio3_7,
        Gpio3_8,
        Gpio3_9,
        Gpio3_10,
        Gpio3_11,
        Gpio3_12,
        Gpio3_13,
        Gpio3_14,
        Gpio3_15,
        Gpio3_16,
        Gpio3_17,
        Gpio3_18,
        Gpio3_19,
        Gpio3_20,
        Gpio3_21,
        Gpio3_22,
        Gpio3_23,
        Gpio3_24,
        Gpio3_25,
        Gpio3_26,
        Gpio3_27,
        Gpio3_28,
        Gpio3_29,
        Gpio3_30,
        Gpio3_31,
        Gpio4_0,
        Gpio4_1,
        Gpio4_2,
        Gpio4_3,
        Gpio4_4,
        Gpio4_5,
        Gpio4_6,
        Gpio4_7,
        Gpio4_8,
        Gpio4_9,
        Gpio4_10,
        Gpio4_11,
        Gpio4_12,
        Gpio4_13,
        Gpio4_14,
        Gpio4_15,
        Gpio4_16,
        Gpio4_17,
        Gpio4_18,
        Gpio4_19,
        Gpio4_20,
        Gpio4_21,
        Gpio4_22,
        Gpio4_23,
        Gpio4_24,
        Gpio4_25,
        Gpio4_26,
        Gpio4_27,
        Gpio4_28,
        Gpio4_29,
        Gpio4_30,
        Gpio4_31
    }
}