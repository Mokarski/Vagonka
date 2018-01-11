using System;
using System.Threading;
using SDK.NetworksServices.Services.Journal;

namespace Journal
{
    class Program
    {
        static void Main()
        {
            var journalService = new JournalService(true);
            
            journalService.Start();
            Console.WriteLine("Journal started");

            while (true)
            {
                Thread.Sleep(500);
            }
        }
    }
}
