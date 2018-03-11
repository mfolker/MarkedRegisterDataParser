using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkedRegisterDataParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Marked Register Data Parser Running");



            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    public static class AppSettings
    {
        public static string PostalVoteDataPath = "D:\\PostalVoteData";

        public static string OriginalFileName = "NewcastleEastCleanPVMarkedRegisterData.csv";

        //OuseburnConnectData
        //HeatonConnectData
    }
}
