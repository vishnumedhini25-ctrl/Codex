using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_2
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            int Month;
            Console.WriteLine("Enter Month Number(1 for January,2 for February,.....12 for December)");
            Month = Convert.ToInt16(Console.ReadLine());

            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 Days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 Days");
                    break;
                case 2:
                    Console.WriteLine("28 or 29 Days");
                    break;

                default:
                    Console.WriteLine("Invalid Month Number");
                    break;
            }
            // while loop
              
            int input;
            Console.Write("Enter a Number : ");
            input = Convert.ToInt16(Console.ReadLine());

            while(input <= 6)
            {
                Console.WriteLine("Number : " + input);
                input++;
            }

                   

            
        }
    }
}
