
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GitPowershell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Download();
            Download1();
            Console.ReadLine();
        }
        static void Download()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Completed");
        }
        static void Download1()
        {

            Task Run() => { Thread.Sleep(3000);
                Console.WriteLine("comletion 1");
            };
        }
            
        }
    }
}
