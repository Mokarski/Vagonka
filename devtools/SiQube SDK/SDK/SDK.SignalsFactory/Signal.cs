using System;
using System.Collections.Generic;
using System.Linq;
using SDK.SignalsFactory.Interface;

namespace SDK.SignalsFactory
{
    public class Signal : ISignal
    {
        /// <summary>
        /// ѕервична€ установка данных по сигналу
        /// </summary>
        private void Init(string id = "", string description = "", byte level = 0)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("Id cann't be null or empty");

            Specification = new SignalSpecification(id, description, level);
            QtSpecification = new QtSignalSpecification();
            State = SignalState.Disconnected;

        }

        public Signal()
        {
            Init();
        }

        public Signal(string id)
        {
            Init(id);
        }

        public Signal(string id, string description, byte level = 0)
        {
            Init(id, description, level);
        }

        public Signal(SignalSpecification specification)
        {
            Specification = specification;
            State = SignalState.Disconnected;
            QtSpecification = new QtSignalSpecification();
        }

        /// <summary>
        /// —татические данные по сигналу - описание
        /// </summary>
        public SignalSpecification Specification { get; private set; }
        public QtSignalSpecification QtSpecification { get; private set; }

        public event SignalEvent OnUpdate;
        public event SignalEvent OnChange;

        #region Calibration

        private readonly Dictionary<float, float> mCalibrationTable = new Dictionary<float, float>();

        /// <summary>
        /// ƒобавл€ем калибровочную точку
        /// </summary>
        /// <param name="value">значение датчика</param>
        /// <param name="physical">физическа€ величина, соответсвующа€ значению датчика</param>
        /// <returns>”становлено или нет</returns>
        public bool AddCalibrationPoint(float value, float physical)
        {
            bool r = true;
            lock (QtSpecification.lck)
            {
                try
                {
                    mCalibrationTable.Add(value, physical);
                }
                catch 
                {
                    r = false;
                }
            }
            QtSpecification.IsCalibrated = r;
            return r;
        }

        /// <summary>
        /// ќбновл€ем калибровочную точку
        /// </summary>
        /// <param name="oldvalue">значение датчика старое</param>
        /// <param name="newvalue">значение датчика новое</param>
        /// <param name="newphysical">нова€ физическа€ величина, соответсвующа€ значению датчика</param>
        /// <returns>”становлено или нет</returns>
        public bool UpdateCalibrationPoint(float oldvalue, float newvalue, float newphysical)
        {
            bool r = true;
            lock (QtSpecification.lck)
            {
                try
                {
                    if (newphysical < 0.0f)
                    {
                        float rv = 0.0f;
                        bool rez = mCalibrationTable.TryGetValue(oldvalue, out rv);
                        if (rez) newphysical = rv; else newphysical = 0.0f;
                    }
                    //mCalibrationTable.Add(value, physical);
                    if (mCalibrationTable.Remove(oldvalue))
                    mCalibrationTable.Add(newvalue, newphysical);
                }
                catch 
                {
                    r = false;
                }
            }
            QtSpecification.IsCalibrated = r;
            return r;
        }


        public float GetMinCalibrationPointKeyValue(out float cal)
        {
            float min = 0.0f;
            bool r = true;
            float c = 0.0f;
            lock (QtSpecification.lck)
            {
                try
                {
                    min = mCalibrationTable.Keys.Min();
                    mCalibrationTable.TryGetValue(min, out c);
                }
                catch 
                {
                    r = false;
                }
            }

            if (!r)
            {
                cal = 0.0f;
                return -1.0f;
            }

            cal = c;
            return min;
        }

        public float GetMaxCalibrationPointKeyValue(out float cal)
        {

            float min = 0.0f;
            bool r = true;
            float c = 0.0f;
            lock (QtSpecification.lck)
            {
                try
                {
                    min = mCalibrationTable.Keys.Max();
                    mCalibrationTable.TryGetValue(min, out c);
                }
                catch 
                {
                    r = false;
                }
            }

            if (!r)
            {
                cal = 0.0f;
                return -1.0f;
            }

            cal = c;
            return min;
        }

        /// <summary>
        /// —брасываем калибровочные таблицы
        /// </summary>
        public void ClearCalibration()
        {
            QtSpecification.IsCalibrated = false;
            lock (QtSpecification.lck)
            {
                try
                {
                    mCalibrationTable.Clear();
                }
                catch { }
            }
        }

        #endregion

        #region Working with value (update)

        private float mInternalValue = float.NaN;
        private float mValue = float.NaN;

        /// <summary>
        /// “екущее состо€ние сигнала
        /// </summary>
        public SignalState State { get; set; }

        /// <summary>
        /// ¬рем€ последнего обновлени€ данных
        /// </summary>
        public DateTime LastUpdate { get; private set; }

        public float Value
        {
            get { return mInternalValue; }
            private set
            {
                //var valueChanged = Math.Abs(mInternalValue - value) > 0.000001;
                var valueChanged = false;

                if (
                    (float.IsNaN(mInternalValue) && !float.IsNaN(value)) ||
                    (!float.IsNaN(mInternalValue) && float.IsNaN(value))
                    ) valueChanged = true;
                else
                {

                    valueChanged = Math.Abs(mInternalValue - value) >= 0.0001f;
                }
                mInternalValue = value;

                LastUpdate = DateTime.Now;

                // оповещаем об обновлении данных
                if (OnUpdate != null)
                    OnUpdate(this);

                if (OnChange != null && valueChanged)
                    OnChange(this);
            }
        }

        public void PrintCalibarationPoints(string pref = "all")
        {
            float phy1 = 0.0f;
            float phy2 = 0.0f;
            int min = (int)this.GetMinCalibrationPointKeyValue(out phy1);
            int max = (int)this.GetMaxCalibrationPointKeyValue(out phy2);
            switch(pref)
            {
                case "min":
            Console.WriteLine("Signal " + this.Specification.Id
                + ": min - " + min.ToString() + " phy - " + 
                phy1.ToString()
                );
                    break;
                case "max":
            Console.WriteLine("Signal " + this.Specification.Id
                + ": max - " + max.ToString() + " phy - " +
                phy2.ToString()
                );
                    break;
                default:
            Console.WriteLine("Signal " + this.Specification.Id
                + ": min - " + min.ToString() + " phy - " + 
                phy1.ToString()
                );
            Console.WriteLine("Signal " + this.Specification.Id
                + ": max - " + max.ToString() + " phy - " +
                phy2.ToString()
                );
                    break;
            }

        }

        private bool UpdateValue(float value)
        {
            mValue = value;

                switch(mCalibrationTable.Count)
                {
                    case 2:
                    case 4:
                        break;
                    default:
                    Value = mValue;
                    return true;

                }

                if (float.IsNaN(mValue)) QtSpecification.raw = 0; else QtSpecification.raw = (UInt16)mValue;
                    float minCalibrate = 0.0f;
                    float maxCalibrate = 0.0f;
                    float min = 0.0f;
                    float max = 0.0f;
                    bool r = true;
                    try
                    {
                        min = mCalibrationTable.Keys.Min();
                        mCalibrationTable.TryGetValue(min, out minCalibrate);
                    }
                    catch 
                    {
                        r = false;
                    }
                    if (!r || (min < 0.0f))
                    {
                        Value = float.NaN;
                        return true;
                    }

                    try
                    {
                        max = mCalibrationTable.Keys.Max();
                        mCalibrationTable.TryGetValue(max, out maxCalibrate);
                    }
                    catch 
                    {
                        r = false;
                    }
                    if (!r || (max < 0.0f))
                    {
                        Value = float.NaN;
                        return true;
                    }

                        if (mValue < min)
                        {
                            Value = float.NaN;
                            return true;
                        }

                            if (Math.Abs(mValue - min) < 0.01f)
                            {
                                Value = minCalibrate;
                                return true;
                            }

                                if (Math.Abs(mValue - max) < 0.01f)
                                {
                                    Value = maxCalibrate;
                                    return true;
                                }

                                        float point = (max - min);
                                        float offsetValue = mValue - min;

                                        float step = ((maxCalibrate - minCalibrate) / point);
                                        Value = minCalibrate + step * offsetValue;
            return true;
        }
        
        public virtual void Update(float value)
        {
            if (QtSpecification.IsCalibrated)
            {
                lock (QtSpecification.lck)
                {
                    UpdateValue(value);
                }
            }
            else UpdateValue(value);

            /*
            // если не обновилось значение, то нет и остальных действий
            if (!UpdateValue(value)) return;


            // если есть авари€, то нет предупреждени€
            if (CallOnAlarm()) return;

            // если есть предупреждение, то датчик не может быть нормально-включенным
            if (CallOnWarning()) return;
            */

            State = SignalState.Connected;
        }
        

        public void Update(uint value)
        {
            if (QtSpecification.IsCalibrated)
            {
                lock (QtSpecification.lck)
                {
                    Update((float)value);
                }
            }
            else Update((float)value);
        }

        public void Update(bool value)
        {
            if (QtSpecification.IsCalibrated)
            {
                lock (QtSpecification.lck)
                {
                    Update(value ? 1.0f : 0.0f);
                }
            }
            else Update(value ? 1.0f : 0.0f);
        }

        public virtual bool IsSet
        {
            get { return Value > 0.1f; }
        }

        public int ValueAsInt
        {
            get { return (int) Value; }
        }

        public bool IsStorage { get; set; }

        public CalibrationPoints CalibrationPoints
        {
            // TODO
            get { return new CalibrationPoints(); }
        }

        #endregion

        #region Format output

        public override string ToString()
        {
            return float.IsNaN(Value) ? "-" : string.Format("{0:F2}", Value);
        }

        #endregion
    }
}

/*
public bool? GetAsBool()
{
if (Type != SignalType.Bool)
return null;

return GetRangeAsEnum()[(int)Data].Contains("true");
}

protected int Data { get; set; }

public ushort? GetAsUshort()
{
if (Type != SignalType.Ushort)
return null;

return (ushort?)GetRangeAsFloat()[(ushort)Data];
}

public float? GetAsFloat()
{
if (Type != SignalType.Float)
return null;

return GetRangeAsFloat()[(int)Data];
}

public string GetAsString()
{
if (Type == SignalType.Enum || Type == SignalType.Bool)
return GetRangeAsEnum()[(int)Data];

return Type == SignalType.Action ? Id : GetRangeAsFloat()[(int)Data].ToString(new CultureInfo("en-US"));
}
*/
