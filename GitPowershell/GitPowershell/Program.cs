﻿
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
            Console.ReadLine();
        }
        static void Download()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Completed");
        }
    }
}