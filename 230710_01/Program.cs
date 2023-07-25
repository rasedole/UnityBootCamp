using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230710_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMoney = 10;
            int numberOfMana = 20;
            string inputValue = Console.ReadLine();

            Console.WriteLine(int.Parse(inputValue) + numberOfMana);
        }
    }
}
