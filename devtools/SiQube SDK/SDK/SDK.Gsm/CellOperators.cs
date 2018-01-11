using System;
using System.Collections.Generic;

namespace SDK.Gsm
{
    public class CellOperators
    {
        private readonly Dictionary<ushort, CellOperatorInfo> mOperatorsInfo = new Dictionary<ushort, CellOperatorInfo>();

        public CellOperators()
        {
            #region Default Operators
            Add(25001, new CellOperatorInfo("mts", "mts", "internet.mts.ru", "*99***1#", "")); // MTS-RUS
            Add(25702, new CellOperatorInfo("mts", "mts", "internet.mts.ru", "*99***1#", "")); // MTS-BY
            Add(29402, new CellOperatorInfo("mts", "mts", "internet.mts.ru", "*99***1#", "")); // MTS-AD

            Add(25099, new CellOperatorInfo("beeline", "beeline", "internet.beeline.ru", "*99***1#", "")); // BEE LINE 

            Add(25002, new CellOperatorInfo("gdata", "gdata", "internet", "*99#", "")); // MegaFon

            Add(24701, new CellOperatorInfo("lmt", "lmt", "internet.lmt.lv", "*99***1#", "")); // LMT GSM

            Add(23430, new CellOperatorInfo("mts", "mts", "everywhere", "*99***1#", "")); // EE - T-MOBILE UK
            #endregion
        }

        public bool Add(UInt16 operatorId, CellOperatorInfo info)
        {
            if (info != null)
            {
                if(mOperatorsInfo.ContainsKey(operatorId))
                    mOperatorsInfo.Remove(operatorId); // перетираем настройки по умолчанию

                mOperatorsInfo.Add(operatorId, info);

                return true;
            }

            return false;
        }

        public CellOperatorInfo Get(UInt16 operatorId)
        {
            CellOperatorInfo info;
            mOperatorsInfo.TryGetValue(operatorId, out info);

            return info;
        }
    }
}