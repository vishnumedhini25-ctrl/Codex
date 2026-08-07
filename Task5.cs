using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_2
{
    class Program2
    {
        static void Main (string [] args)
        {
            int rows;
            Console.Write("Enter The Number :");
            rows = int.Parse(Console.ReadLine());

            int i = 1;
            while(i <= rows)
            {
                int j = 1;
                while(j <= i)
               {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            };
            Console.ReadLine();

            //do...while

            int n = 0;
            n = 10;

            do
            {
                Console.WriteLine("The Number for n is : " + n);
                n = n + 10;

            } while (n < 100);

            //for....loop

            int num;
            Console.Write("Enter a number to find its multiples :");
            num = int.Parse (Console.ReadLine());

            for(int mutipl=1;  mutipl <= 10; mutipl++)
            {
                Console.WriteLine(num + "*" + mutipl +"=" + num*mutipl);
            }
            Console.ReadLine ();

            //Collection and foreach...

            int[] Marks = new int[5];

            Marks[0] = 65;
            Marks[1] = 72;
            Marks[2] = 54;
            Marks[3] = 89;
            Marks[4] = 75;

            foreach (int Mark in Marks)
            {
                Console.WriteLine("Marks :" + Mark);
            }
            Console.ReadLine();


        }

    }
}
