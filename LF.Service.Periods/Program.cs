using Microsoft.Owin.Hosting;
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

            //OWIN 启动
            var _server = WebApp.Start<Startup>("http://+:6001");
            Console.ReadKey();

        }
    }
}
