using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Beep();
            Console.Write(a);
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.Read();
        }
    }
}
