using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SDK.SignalsFactory.Interface;

namespace SDK.SignalsFactory
{
    public class FloatSignal : Signal
    {
        public FloatSignal(string id, string description, float defaultValue)
            : base(id, description, 0)
        {
            //SaveAsFloat(defaultValue);
        }

        public FloatSignal(string id, string description)
            : this(id, description, 0)
        {
        }

        public FloatSignal(string id)
            : this(id, "")
        {
        }

        public FloatSignal(string id, string description, float defaultValue, float value)
            : this(id, description, defaultValue)
        {
            Update(value);
        }
    }

    public class RealtimeFloatSignal : FloatSignal
    {
        public RealtimeFloatSignal(string id, string description, float value)
            : base(id, description, 0, value)
        {
            IsStorage = false;
        }

        public RealtimeFloatSignal(string id, string description)
            : base(id, description, 0)
        {
            IsStorage = false;
        }

        public RealtimeFloatSignal(string id)
            : this(id, "")
        {
        }

        public RealtimeFloatSignal(string id, float value)
            : this(id, "", value)
        {
            IsStorage = false;
        }
    }

    public class UshortSignal : Signal
    {
        public UshortSignal(string id, string description, ushort defaultValue, ushort min, ushort step, ushort max)
            : base(id, description)
        {
            //SaveAsUshort(defaultValue, true, min, step, max);
        }

        public UshortSignal(string id, string description, ushort defaultValue)
            : base(id, description)
        {
            //SaveAsUshort(defaultValue);
        }
    }

    public class BoolSignal : Signal
    {
        public BoolSignal(string id, string description, bool defaultValue)
            : base(id, description)
        {
            //SaveAsBool(defaultValue);
        }
    }
    
    public class CalibrationPoint
    {
        public CalibrationPoint(int raw, float physical)
        {
            Raw = raw;
            Physical = physical;
        }

        public int Raw { get; private set; }
        public float Physical { get; private set; }
    }

    public class CalibrationPoints
    {
        private readonly Dictionary<int, float> _points = new Dictionary<int, float>();

        /// <summary>
        /// Добавляем калибровочную точку
        /// </summary>
        /// <param name="raw">значение датчика</param>
        /// <param name="physical">физическая величина, соответсвующая значению датчика</param>
        /// <returns>Установлено или нет</returns>
        public bool Add(int raw, float physical)
        {
            if (_points.ContainsKey(raw))
                return false;

            _points.Add(raw, physical);
            return true;
        }

        /// <summary>
        /// Добавляем калибровочную точку
        /// </summary>
        /// <param name="point">Калибровочная точка</param>
        /// <returns>Установлено или нет</returns>
        public bool Add(CalibrationPoint point)
        {
            if (point == null)
                return false;

            return Add(point.Raw, point.Physical);
        }

        /// <summary>
        /// Заменяем калибровочные точки
        /// </summary>
        /// <param name="points">Калибровочные точки</param>
        public void Replace(IEnumerable<CalibrationPoint> points)
        {
            Clear();

            if (points == null)
                return;

            foreach (var point in points)
                Add(point);
        }

        /// <summary>
        /// Сбрасываем калибровочные таблицы
        /// </summary>
        public void Clear()
        {
            _points.Clear();
        }

        public float ToPhysical(float value)
        {
            if (_points.Count == 0)
                return value;

            int min;
            try
            {
                min = _points.Keys.Last(s => s <= value);
            }
            catch (InvalidOperationException)
            {
                return float.NaN;
            }

            float minCalibrate;
            _points.TryGetValue(min, out minCalibrate);
            if (value < min)
                return float.NaN;

            if (Math.Abs(value - min) < 0.01)
                return minCalibrate;

            var max = _points.Keys.FirstOrDefault(s => s >= value);

            float maxCalibrate;
            _points.TryGetValue(max, out maxCalibrate);
            if (Math.Abs(value - max) < 0.01)
                return maxCalibrate;

            if (max < min)
                return float.NaN;

            var point = (max - min);
            var offsetValue = value - min;

            var step = ((maxCalibrate - minCalibrate) / point);
            return minCalibrate + step * offsetValue;
        }
    }

    /// <summary>
    /// Идентификатор сигнала
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field, AllowMultiple = false)]
    public class IdAttribute : Attribute
    {
        public string Id { get; set; }

        public IdAttribute(string id)
        {
            Id = id;
        }
    }

    /// <summary>
    /// Массив идентификаторов сигналов
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field, AllowMultiple = true)]
    public class IdsAttribute : Attribute
    {
        private readonly List<Tuple<Type, string>> _ids = new List<Tuple<Type, string>>();

        public IEnumerable<Tuple<Type, string>> Ids
        {
            get { return _ids; }
        }

        public IdsAttribute(params string[] ids)
            : this(null, ids)
        {
        }

        public IdsAttribute(Type type, params string[] ids)
        {
            foreach (var id in ids)
                _ids.Add(new Tuple<Type, string>(type, id));
        }
    }

    /// <summary>
    /// Описание сигнала
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class DescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public DescriptionAttribute(string description)
        {
            Description = description;
        }
    }

    /// <summary>
    /// Реалтаймовый сигнал
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class RealtimeAttribute : Attribute
    {
    }

    /// <summary>
    /// 16 битный тип сигнала
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class UshortSignalAttribute : Attribute
    {
        public SignalType Type { get; private set; }

        public ushort DefaultValue { get; set; }
        public ushort Min { get; set; }
        public ushort Max { get; set; }
        public ushort Step { get; set; }

        public UshortSignalAttribute(ushort defaultValue)
        {
            Type = SignalType.Ushort;
            DefaultValue = defaultValue;
            Min = ushort.MinValue;
            Max = ushort.MaxValue;
            Step = 1;
        }
    }

    /// <summary>
    /// Сигнал с плавающей точкой одиночной точности
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class FloatSignalAttribute : Attribute
    {
        private float? _defaultValue;
        private float? _value;

        public SignalType Type { get; private set; }

        public float DefaultValue
        {
            get { return _defaultValue.GetValueOrDefault(); }
            set { _defaultValue = value; }
        }

        public float Value
        {
            get { return _value.GetValueOrDefault(); }
            set { _value = value; }
        }

        public bool HasDefaultValue { get { return _defaultValue != null; } }
        public bool HasValue { get { return _value != null; } }

        public FloatSignalAttribute()
        {
            Type = SignalType.Float;
            DefaultValue = 0;
        }
    }

    /// <summary>
    /// Дискретный тип сигнала
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class BoolSignalAttribute : Attribute
    {
        public SignalType Type { get; private set; }
        public bool DefaultValue { get; set; }

        public BoolSignalAttribute()
        {
            Type = SignalType.Bool;
            DefaultValue = false;
        }
    }

    /// <summary>
    /// Калибровочные таблицы сигнала
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class CalibrationAttribute : Attribute
    {
        private readonly List<CalibrationPoint> _points = new List<CalibrationPoint>();

        public IEnumerable<CalibrationPoint> Points
        {
            get
            {
                return _points;
            }
        }

        public CalibrationAttribute(int[] raws, float[] physicals)
        {
            var size = Math.Min(raws.Length, physicals.Length);
            for (var i = 0; i < size; i++)
                _points.Add(new CalibrationPoint(raws[i], physicals[i]));
        }

        public CalibrationAttribute(int raw1, float physical1, int raw2, float physical2)
        {
            _points.Add(new CalibrationPoint(raw1, physical1));
            _points.Add(new CalibrationPoint(raw2, physical2));
        }
    }

    /// <summary>
    /// Считыватель информации с иерархии классов и построитель сигналов в будущем
    /// </summary>
    public class SignalBuilder
    {
        private readonly ISignalsFactory _signals;

        public SignalBuilder(ISignalsFactory signals)
        {
            _signals = signals;
        }

        public void Init(Type type)
        {
            var fields = GetFields(type);

            InitIds(fields);
            InitSignals(fields);
            InitArrays(fields);
        }

        private void InitArrays(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields.Where(IsSignalArray))
            {
                var ids = new List<string>();

                var idFields = GetIdFields(field);
                foreach (var idField in idFields)
                {
                    var type = idField.Item1 ?? field.ReflectedType;
                    var member = idField.Item2;

                    var memberField = FindMemberField(type, member);
                    if (memberField != null)
                        ids.Add(GetFullId(memberField));
                }

                field.SetValue(null, ids.ToArray());
            }
        }

        private FieldInfo FindMemberField(Type type, string member)
        {
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static).Where(IsSignalIdField).ToList();
            return fields.FirstOrDefault(field => field.Name.Equals(member));
        }

        private IEnumerable<Tuple<Type, string>> GetIdFields(FieldInfo field)
        {
            var attributes = field.GetCustomAttributes(typeof(IdsAttribute), false);
            var ids = new List<Tuple<Type, string>>();
            foreach (var idsAttribute in attributes.OfType<IdsAttribute>())
                ids.AddRange(idsAttribute.Ids);

            return ids;
        }

        private List<FieldInfo> GetFields(Type type)
        {
            var fields = new List<FieldInfo>();

            fields.AddRange(GetTypeFields(type));
            var innerTypes = GetInnerClassTypes(type);
            foreach (var innerType in innerTypes)
                fields.AddRange(GetFields(innerType));

            return fields;
        }

        private IEnumerable<FieldInfo> GetTypeFields(Type type)
        {
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);
            return fields.Where(IsValidField).ToList();
        }

        private IEnumerable<Type> GetInnerClassTypes(Type type)
        {
            return type.GetNestedTypes(BindingFlags.Public | BindingFlags.Instance);
        }

        private bool IsValidField(FieldInfo field)
        {
            return IsSignalIdField(field) || IsSignalArrayField(field);
        }

        private bool IsSignalArrayField(FieldInfo field)
        {
            return HasValidArrayAttribute(field) && IsSignalArray(field);
        }

        private bool IsSignalIdField(FieldInfo field)
        {
            return HasValidTypeAttribute(field) && IsSignalId(field);
        }

        private static bool IsSignalId(FieldInfo field)
        {
            return field.FieldType == typeof(string);
        }

        private bool IsSignalArray(FieldInfo field)
        {
            return field.FieldType == typeof(string[]);
        }

        private bool HasValidTypeAttribute(FieldInfo field)
        {
            var count = GetAttributeCount(field, typeof(UshortSignalAttribute)) +
                GetAttributeCount(field, typeof(FloatSignalAttribute)) +
                GetAttributeCount(field, typeof(BoolSignalAttribute));

            return count == 1;
        }

        private bool HasValidArrayAttribute(FieldInfo field)
        {
            return GetAttributeCount(field, typeof(IdsAttribute)) > 0;
        }

        private int GetAttributeCount(FieldInfo field, Type attributeType)
        {
            return field.GetCustomAttributes(attributeType, false).Length;
        }

        private void InitIds(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields.Where(IsSignalId))
                field.SetValue(null, GetFullId(field));
        }

        private string GetFullId(FieldInfo field)
        {
            return CombineId(GetFullRootId(field), GetIdOrDefault(field));
        }

        private string CombineId(string id1, string id2)
        {
            if (string.IsNullOrEmpty(id1))
                return id2;

            if (string.IsNullOrEmpty(id2))
                return id1;

            return id1 + "." + id2;
        }

        private string GetFullRootId(FieldInfo field)
        {
            var parentId = string.Empty;
            var parentType = field.ReflectedType;
            while (parentType != null)
            {
                parentId = CombineId(GetId(parentType), parentId);
                parentType = parentType.ReflectedType;
            }

            return parentId;
        }

        public void Init<T>()
        {
            Init(typeof(T));
        }

        private string GetId(Type type)
        {
            var attribute = (IdAttribute)type.GetCustomAttributes(typeof(IdAttribute), false).FirstOrDefault();
            return attribute != null ? attribute.Id : type.Name.ToLower();
        }

        private string GetIdOrDefault(FieldInfo field)
        {
            var attribute = (IdAttribute)field.GetCustomAttributes(typeof(IdAttribute), false).FirstOrDefault();
            return attribute != null ? attribute.Id : field.Name.ToLower();
        }

        private void InitSignals(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields.Where(IsSignalId))
            {
                var signal = CreateSignal(field);
                if (signal == null)
                    continue;

                _signals.Add(signal);
            }
        }

        private Signal CreateSignal(FieldInfo field)
        {
            var id = GetFullId(field);
            if (string.IsNullOrEmpty(id))
                return null;

            var signal = (CreateFloatSignal(id, field) ?? CreateUshortSignal(id, field)) ?? CreateBoolSignal(id, field);
            if (signal != null)
                signal.IsStorage = !HasRealtime(field);

            LoadCalibration(field, signal);

            return signal;
        }

        private void LoadCalibration(FieldInfo field, Signal signal)
        {
            if (signal == null)
                return;

            var attribute = (CalibrationAttribute)field.GetCustomAttributes(typeof(CalibrationAttribute), false).FirstOrDefault();
            if (attribute == null)
                return;

            signal.CalibrationPoints.Replace(attribute.Points);
        }

        private Signal CreateBoolSignal(string id, FieldInfo field)
        {
            var boolAttribute = GetBoolAttribute(field);
            if (boolAttribute == null)
                return null;

            return new BoolSignal(id, GetDescription(field), boolAttribute.DefaultValue);
        }

        private static BoolSignalAttribute GetBoolAttribute(FieldInfo field)
        {
            return (BoolSignalAttribute)field.GetCustomAttributes(typeof(BoolSignalAttribute), false).FirstOrDefault();
        }

        private Signal CreateFloatSignal(string id, FieldInfo field)
        {
            var attribute = GetFloatAttribute(field);
            if (attribute == null)
                return null;

            Signal signal;
            if (attribute.HasDefaultValue)
                signal = new FloatSignal(id, GetDescription(field), attribute.DefaultValue);
            else
                signal = new FloatSignal(id) {};// { Description = GetDescription(field) }};

            if (attribute.HasValue)
                signal.Update(attribute.Value);

            return signal;
        }

        private static FloatSignalAttribute GetFloatAttribute(FieldInfo field)
        {
            return (FloatSignalAttribute)field.GetCustomAttributes(typeof(FloatSignalAttribute), false).FirstOrDefault();
        }

        private Signal CreateUshortSignal(string id, FieldInfo field)
        {
            var ushortAttribute = GetUshortAttribute(field);
            if (ushortAttribute == null)
                return null;

            return new UshortSignal(id, GetDescription(field), ushortAttribute.DefaultValue,
                ushortAttribute.Min, ushortAttribute.Step, ushortAttribute.Max);
        }

        private static UshortSignalAttribute GetUshortAttribute(FieldInfo field)
        {
            return (UshortSignalAttribute)field.GetCustomAttributes(typeof(UshortSignalAttribute), false).FirstOrDefault();
        }

        private bool HasRealtime(FieldInfo field)
        {
            return field.GetCustomAttributes(typeof(RealtimeAttribute), false).FirstOrDefault() != null;
        }

        private string GetDescription(FieldInfo field)
        {
            var attribute = (DescriptionAttribute)field.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();
            return attribute != null ? attribute.Description : string.Empty;
        }
    }
}