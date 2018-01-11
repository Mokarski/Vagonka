using System;
using SDK.Common;

namespace SDK.NetworksServices.Services.Journal
{
    class JournalDbRecord
    {
        [NotNull]
        public int Type { get; set; }

        [NotNull]
        [Indexed]
        public DateTime Time { get; set; }

        public string Message { get; set; }

        public int Level { get; set; }
    }
}