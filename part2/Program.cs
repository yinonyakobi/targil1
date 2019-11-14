using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] occupied = new bool[12, 31];
            occupied.Initialize(false);


            bool exit = false;
            int decision;
            while (!exit) 
            {
                printMenu();
                
                decision = Console.Read();
                switch (decision)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        exit = true;
                        break;
                }


            }

        }

        static void printMenu()
        {
            Console.WriteLine(
            @"
            To book a date enter: 1

            To show occupied dates enter: 2

            To show the number of booked days and percentage of days that are booked enter: 3

            To exit enter: 4");
        }
    }
}
