namespace Sensors.B17K
{
    public enum SystemName
    {
        /// <summary>
        /// �������� �������
        /// </summary>
        Pump,
        
        /// <summary>
        /// ��������
        /// </summary>
        Uz,

        /// <summary>
        /// ��������
        /// </summary>
        Conveyor,

        /// <summary>
        /// ������� ���������� ���������
        /// </summary>
        System
    }
    
    public enum RelayName
    {
        /// <summary>
        ///  ������ ����� �������� ����� - �����������: ������
        /// </summary>
        Kv1, 

        /// <summary>
        /// ������ ����� �������� ����� - �����������: �����
        /// </summary>
        Kv2,

        /// <summary>
        /// �������� ��������������
        /// </summary>
        Kv4,

        /// <summary>
        /// ����� ��� (uz5 �� �������� ������)
        /// </summary>
        Kv8,

        /// <summary>
        /// ����� ��������� (uz5 �� ��������)
        /// </summary>
        Kv9,
        /// <summary>
        /// ��������� ����� - ���������� �� �������� + ������ ��������� ��������� (100%)
        /// </summary>
        Kv10,
        
        /// <summary>
        /// �������� �������
        /// </summary>
        Kv11,

        /// <summary>
        /// ����� ����������
        /// </summary>
        RectifierReset
    }

    public enum SignalName
    {
        Forward,
        Reverse,
        Empty,
        Mode,
        Error,
        Current,
        Voltage,
        Temperature,
        Speed,      
        Feedback,
        Status,
        Level,
        Pressure,
        Roll,
        Pitch,
        Angle,
        Frequency, 
        //��� ���� � ������� ��� ������
        Year,
        Month,
        Date,
        Hour,
        Minutes       
    }

    public enum SignalDate
    {
        Year,
        Month,
        Date,
        Hour,
        Minutes       

    }

    public class SensorName
    {
        public static string Cord(byte channel)
        {
            const string kParent = "cord";
            return string.Format("{0}.f{1}", kParent, channel);
        }

        public static string Relay(RelayName channel)
        {
            return Relay(channel, SignalName.Empty);
        }

        public static string Relay(RelayName channel, SignalName sensor)
        {
            var rv = sensor.ToString();
            switch (sensor)
            {
                case SignalName.Feedback:
                    {
                        switch (channel)
                        {
                            case RelayName.Kv1:
                                rv = "k3";
                                break;

                            case RelayName.Kv2:
                                rv = "k2";
                                break;

                            case RelayName.Kv8:
                                rv = "k4";
                                break;

                            case RelayName.Kv9:
                                rv = "k6";
                                break;

                            case RelayName.Kv10:
                                //rv = "k6";
                                rv = "k5";
                                break;

                            case RelayName.Kv11:
                                rv = "k1";
                                break;
                        }
                    }
                    break;

            }

            const string kParent = "relay";
            return (sensor == SignalName.Empty ? string.Format("{0}.{1}", kParent, channel) : string.Format("{0}.{1}.{2}", kParent, channel, rv)).ToLower();
        }

        public static string Steering(SignalName sensor)
        {
            const string kParent = "local.steering";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Cabel(SignalName sensor)
        {
            const string kParent = "local.cabel";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Filter(SignalName sensor)
        {
            const string kParent = "local.filter";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Brake(SignalName sensor)
        {
            const string kParent = "local.brake";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Date(SignalName sensor)
        {
            const string kParent = "local.date";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Year(SignalName sensor)
        {
            const string kParent = "local.year";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Month(SignalName sensor)
        {
            const string kParent = "local.month";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Hour(SignalName sensor)
        {
            const string kParent = "local.hour";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Minutes(SignalName sensor)
        {
            const string kParent = "local.minutes";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Keyboard()
        {
            const string kParent = "local.keyboard";
            return string.Format("{0}", kParent).ToLower();
        }

        public static string Drive(SignalName sensor)
        {
            const string kParent = "drive";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Invertor(byte channel)
        {
            return Invertor(channel, SignalName.Empty).ToLower();
        }

        public static string Invertor(byte channel, SignalName sensor)
        {
            const string kParent = "uz";
            return (sensor == SignalName.Empty ? string.Format("{0}.{1}", kParent, channel + 1) : string.Format("{0}.{1}.{2}", kParent, channel + 1, sensor)).ToLower();
        }

        public static string Phase(byte channel, SignalName sensor)
        {
            const string kParent = "phase";
            return string.Format("{0}.{1}.{2}", kParent, channel, sensor).ToLower();
        }

        public static string Tank(SignalName sensor)
        {
            const string kParent = "local.tank";
            return string.Format("{0}.{1}", kParent, sensor).ToLower();
        }

        public static string Rectifier()
        {
            return Rectifier(SignalName.Empty).ToLower();
        }

        public static string Rectifier(SignalName sensor)
        {
            return Invertor(0, sensor);
        }

        public static string Empty()
        {
            return "";
        }

        public static string Derivative(SystemName system, SignalName sensor)
        {
            const string kParent = "derivative";
            return string.Format("{0}.{1}.{2}", kParent, system, sensor).ToLower();
        }

        public static string Derivative(SystemName system, int channel, SignalName sensor)
        {
            const string kParent = "derivative";
            return string.Format("{0}.{1}.{2}.{3}", kParent, system, channel, sensor).ToLower();
        }
    }
}