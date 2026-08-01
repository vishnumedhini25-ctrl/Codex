using System;
namespace PROJECT_2
{
    class Program
{
    static void Main(string[] args)
    {
        

        int Mark1, Mark2, Difference;
        Console.WriteLine("Enter Your Mark1 :");
        Mark1 = Convert.ToInt16(Console.ReadLine());
        Console.ReadLine();

        Console.WriteLine("Enter Your Mark2 :");
        Mark2 = int.Parse(Console.ReadLine());
        Console.ReadLine();

        int sum;
        sum = Mark1 + Mark2;
        Console.WriteLine("Sum :" + sum);
        Console.ReadLine();


        Difference = Mark1 - Mark2;
        Console.WriteLine("Difference :" + Difference);
        Console.ReadLine();


            //if condition 

            int Castingvote;
            Console.WriteLine("Enter Your Age : ");
            Castingvote = Convert.ToInt16(Console.ReadLine());
            if( Castingvote == 18)
            {
                Console.WriteLine("Your Are Eligible For Voting");

            }
            else
            {
                Console.WriteLine("Your Are Not Eligible For Voting");
            }

            int Num1,Num2;
            Console.WriteLine("Enter The Number1 : ");
            Num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter The Number2 : ");
            Num2 = Convert.ToInt16(Console.ReadLine());
             
            if(Num1 == Num2)
            {
                Console.WriteLine("The Two Numbers Are Equal");
            }
            else if(Num1 > Num2)
            {
                Console.WriteLine("Number1 is greater than Number2");
            }
            else if( Num1 < Num2)
            {
                Console.WriteLine("Number1 is less than Number2");

            }
            else
            {
                Console.WriteLine("The Two Numbers Are Not Equal");
            }





        }
    }
}
