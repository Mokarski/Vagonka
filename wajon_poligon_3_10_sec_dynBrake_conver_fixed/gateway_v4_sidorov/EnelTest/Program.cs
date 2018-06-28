using SDK.NetworksServices.Interfaces;
using SDK.NetworksServices.Services.Journal;
using SDK.SignalsFactory.Modbus;

namespace EnelTest
{
    class Program
    {
        static void Main()
        {
            var journal = new ConsoleJournal(); 
            var connection = new RS485Master(journal, "/dev/ttySP1", 57600, false);
            connection.Open();

            while (true)
            {                
                journal.Debug("try to write frequency", MessageLevel.System);
                if(connection.Write(0, 257, new ushort[] {100}))
                    journal.Info("broadcast write success", MessageLevel.System);
                else
                    journal.Warning("broadcast write timeout", MessageLevel.System);
            }
        }
    }
}
