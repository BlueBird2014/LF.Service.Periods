using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LF.Service.Periods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program run!");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Welcome:" + i);
                NLog.LogManager.GetLogger("Log").Info("Welcome:" + i);
                Thread.Sleep(100);
            }
            Console.WriteLine("NLog");

            Console.ReadKey();

        }
    }
}
