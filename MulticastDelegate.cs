using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    internal class MulticastDelegate
    {
        public delegate void MyDelegate(string msg);
        class MyClass
        {
            public static void Print(string message) =>
                Console.WriteLine($"{message.ToUpper()}");
            public static void Show(string message) => Console.WriteLine($"{message.ToLower()}");

            internal static void Display(string msg)
            {
                throw new NotImplementedException();
            }
        }
        class Program
        {
            static object Main(string[] args)
            {
                string msg = "Multicast Delegate";
                MyDelegate MyDele01 = MyClass.Print;
                MyDelegate MyDele02 = MyClass.Show;
                Console.WriteLine("***Combines MyDele01 + MyDele02****");
                MyDelegate MyDele = MyDele01 + MyDele02;
                MyDele(msg);
                Console.WriteLine("***Combines MyDele01 + MyDele02 + MyDele03***");
                MyDelegate MyDele03 = MyClass.Display;
                MyDele += MyDele03;
                MyDele(msg);
                Console.WriteLine("________________");
                Console.WriteLine("***Remove MyDele02***");
                MyDele -= MyDele02;
                MyDele("Hello World !");
                Console.ReadLine;
            }
        }
    }
}
