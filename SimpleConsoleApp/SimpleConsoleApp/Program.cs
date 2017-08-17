using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    class Program
    {
        const string version = "1.0.2";

        static void Main(string[] args)
        {
            Console.WriteLine($"Version {version}");

            Console.WriteLine("Adding super feature");

            Console.ReadLine();
        }
    }
}
