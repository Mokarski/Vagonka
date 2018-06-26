using System.Collections.Generic;
using SDK.SignalsFactory.Interface;

namespace SDK.SignalsFactory.Equipment.Wago
{
    /// <summary>
    /// 16-канальный дискретный модуль ввода
    /// </summary>
    public class W7501405
    {
        static public void Add(Coupler coupler, ushort register, IList<ISignal> signals)
        {
            if (signals == null)
                return;

            if (signals.Count == 0)
                return;

            var data = new ushort[(byte)((signals.Count / 16) + 1)];

            for (ushort i = 0; i < data.Length; i++)
            {
                var count = (i != (data.Length - 1)) ? 16 : signals.Count % 16;
                for (byte j = 0; j < count; j++)
                {
                    if(signals[i * 16 + j] != null)
                        coupler.AddDiscreet(signals[i * 16 + j], (ushort)(register + i), j);
                }
            }
        }
    }
}