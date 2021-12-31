using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Y or N");
            string Answer = Console.ReadLine().ToLower();
            bool DUI = Answer == "n";
            Console.WriteLine("How many speeding tickets do you have?");
            int Speeding = Convert.ToInt32(Console.ReadLine());

            bool canCover = (Age >= 15 && DUI == true && Speeding < 3);
            Console.WriteLine(canCover);
            Console.ReadLine();
        }
    }
}
