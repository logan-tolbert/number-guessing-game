using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class ConsoleFunctions
    {
        public static string GetName()
        {
            Program.DisplayGetName();
            var name = Console.ReadLine()!;
            return name;
       }
    }
}
