using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Program
    {
        public const int NumOfMonthsInAYear = 12;
        public const int NumOfDaysInAMonth = 31;
        static void Main(string[] args)
        {
            bool[,] occupied = new bool[NumOfMonthsInAYear, NumOfDaysInAMonth];
            occupied.Initialize();


            bool exit = false;
            char decision;
            while (!exit)
            {
                printMenu();
                decision = (char)Console.Read();
                switch (decision)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        exit = false;
                        break;
                    case '4':
                        exit = true;
                        break;
                }


            }

        }

        static void printMenu()
        {
            Console.WriteLine(
            @"To book a date enter: 1

To show occupied dates enter: 2

To show the number of booked days and percentage of days that are booked enter: 3

To exit enter: 4
");
        }
        static void countAndPrintOccupiedNumberAndPercentage(bool[,] calender)
        {
            int counter = 0;
            for (int i = 0; i < NumOfMonthsInAYear; i++)
            {
                for (int j = 0; j < NumOfDaysInAMonth; j++)
                {
                    if (calender[i, j])
                        ++counter;
                }
            }
        }
    }
}

