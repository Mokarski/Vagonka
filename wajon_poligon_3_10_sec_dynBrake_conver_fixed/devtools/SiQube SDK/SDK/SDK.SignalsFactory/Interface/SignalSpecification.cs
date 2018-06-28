using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace SDK.SignalsFactory.Interface
{
    
    /// <summary>
    /// ����� ��� �������� ������� QT
    /// </summary>
    public class QtSignalSpecification
    {
        /// <summary>
        /// �������� ������ ����� �������
        /// </summary>
        public Int16 accuracy { get; set; }

        /// <summary>
        /// ������������ �������� ���������������
        /// </summary>
        public Int16 maxvalcal { get; set; }

        /// <summary>
        /// �������� ����� ���
        /// </summary>
        public UInt16 raw { get; set; }

        /// <summary>
        /// ��������, ��������, ��� ������ ��������������� ��� Qt ������
        /// </summary>
        public bool IsConfiguretForQt { get; set; }

        /// <summary>
        /// ��������, ��������, ��� ������ �����������
        /// </summary>
        public bool IsCalibrated { get; set; }


        /// <summary>
        /// Mutex ������ ��� ������������ �������
        /// </summary>
        public object lck;


        public QtSignalSpecification()
        {
            accuracy = 10;
            maxvalcal = 0;
            raw = 0;
            lck = new object();
            IsConfiguretForQt = false;
            IsCalibrated = false;
        }
    }

    /// <summary>
    /// ����� ��� �������� ������� (� ��� ����� � ��� ���������� �������)
    /// </summary>
    public class SignalSpecification
    {
        public SignalSpecification(string id, string description, byte level = 0)
        {
            Init(id, description, level);
        }

        protected SignalSpecification()
        {
            Init("", "", 0);
        }

        /// <summary>
        /// ������������� ��������
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="level"></param>
        private void Init(string id, string description, byte level)
        {
            Id = id;
            Depth = (byte)Id.Split(new[] { '.' }).Length;
            Description = description;
            Level = level;
            Type = SignalType.Action;
        }

        /// <summary>
        /// ����������� �������� ��� ����������������?
        /// </summary>
        public virtual bool IsStorage { get; internal set; }

        /// <summary>
        /// ������� �������
        /// </summary>
        public virtual byte Level { get; internal set; }

        /// <summary>
        /// ������� �������� ��������������
        /// </summary>
        public virtual byte Depth { get; internal set; }

        /// <summary>
        /// �������� �� ���������
        /// </summary>
        public virtual float DefaultValue { get; internal set; }

        /// <summary>
        /// ��� ������
        /// </summary>
        public virtual SignalType Type { get; internal set; }


        /// <summary>
        /// ���������� ��������, �������� hydraulic.brake.pressure
        /// </summary>
        public virtual string Id { get; internal set; }

        /// <summary>
        /// ������������ ��������
        /// </summary>
        public virtual string Description { get; internal set; }

        /// <summary>
        /// ��� ����� - ��� ��������� ��������, ��� �������� �������� - ��� ��������, �����, ��� � ����� ���������
        /// </summary>
        public virtual string Range { get; internal set; }

        public string[] GetRangeAsEnum()
        {
            // ���������� �������� ��� ��������������
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            return Range.Split(new[] { ';' });
        }

        public float[] GetRangeAsFloat()
        {
            if (Type != SignalType.Float)
                return null;

            try
            {
                // ���������� �������� ��� ��������������
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                return Range.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(s => (float)Convert.ToDouble(s, new CultureInfo("en-US"))).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public ushort[] GetRangeAsUshort()
        {
            if (Type != SignalType.Ushort)
                return null;

            try
            {
                // ���������� �������� ��� ��������������
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                return Range.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToUInt16(s, new CultureInfo("en-US"))).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public SignalSpecification SaveAsEnum(float defaultValue, string[] values, bool isStorage)
        {
            if (Type == SignalType.Action)
                Type = SignalType.Enum;

            IsStorage = isStorage;

            // ���������� �������� ��� ��������������
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            var rv = new StringBuilder();
            foreach (var value in values)
            {
                rv.Append(value);
                rv.Append(";");
            }

            Range = rv.ToString();
            DefaultValue = defaultValue;

            return this;
        }

        public SignalSpecification SaveAsFloat(float defaultValue, bool isStorage = true, float min = float.MinValue, float step = 1.0f, float max = float.MaxValue)
        {
            if (Type == SignalType.Action)
                Type = SignalType.Float;

            var values = new[] { min, step, max };
            return SaveAsEnum(defaultValue, values.Select(value => value.ToString(new CultureInfo("en-US"))).ToArray(), IsStorage);
        }


        public void QtSaveAsUshort(ushort defaultValue, ushort min = ushort.MinValue, ushort step = 1, ushort max = ushort.MaxValue)
        {
            // ���������� �������� ��� ��������������
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Range = min.ToString() + ";" + step.ToString() + ";" + max.ToString() + ";";
            DefaultValue = defaultValue;
        }

        public SignalSpecification SaveAsUshort(ushort defaultValue, bool isStorage = true, ushort min = ushort.MinValue, ushort step = 1, ushort max = ushort.MaxValue)
        {
            if (Type == SignalType.Action)
                Type = SignalType.Ushort;

            var values = new[] { min, step, max };
            return SaveAsEnum(defaultValue, values.Select(value => value.ToString(new CultureInfo("en-US"))).ToArray(), isStorage);
        }

        public SignalSpecification SaveAsBool(bool defaultValue, bool isStorage = true)
        {
            if (Type == SignalType.Action)
                Type = SignalType.Bool;

            return SaveAsEnum(defaultValue ? 1 : 0, new[] { "false", "true" }, isStorage);
        }
    }
}