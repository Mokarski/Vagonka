using System.Collections.Generic;
using SDK.SignalsFactory.Interface;

namespace SDK.SignalsFactory.Equipment.Wago
{
    /// <summary>
    /// Модуль трехфазного измерения напряжения (тока)
    /// </summary>
    public class W750493
    {
        static public void Add(Coupler coupler, ushort register, IList<ISignal> signals)
        {
            if (signals == null)
                return;

            if (signals.Count == 0)
                return;

            // add inputs
            for (ushort i = 0; i < signals.Count; i++)
            {
                coupler.AddUshort(signals[i], (ushort) (register + 2*i + 1));
                
                //if (!string.IsNullOrEmpty(ids[i]))
                //        mInputs.Add(new AnalogInput((i % 2 == 0) ? SensorType.Logical : SensorType.Voltage, ids[i], (ushort)(address + i)));
            }

            // add configure outputs
            var output = new List<Signal>
                             {
                                new Signal(string.Format("w750493.internal.1.{0}", register)),
                                new Signal(string.Format("w750493.internal.2.{0}", register)),
                                new Signal(string.Format("w750493.internal.3.{0}", register))
                             };

            //return new ushort[] { 0x01, 0, 0x01, 0, 0x01, 0 }; - for voltage
            coupler.AddInternalUshort(output[0], (ushort)(register + 512), false);
            coupler.AddInternalUshort(output[1], (ushort)(register + 512 + 2), false);
            coupler.AddInternalUshort(output[2], (ushort)(register + 512 + 4), false);

            foreach (var signal in output)
            {
                signal.Update(1);
            }

        }
    }
}