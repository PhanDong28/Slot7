﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    internal class ImpEvnet
    {
        public delegate void PrintDetails(string msg);
        class Program
        {
            // Declaring an event
            event PrintDetails Print;
            void Show(string msg) => Console.WriteLine(msg.ToUpper());
            static void Main(string[] args)
            {
                Program p = new Program();
                // Register with an event
                p.Print += new PrintDetails(p.Show);
                // Raise "Print" event
                p.Print("Hello World.");
                Console.ReadLine();
            }
        }
    }
}

