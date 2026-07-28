

namespace Myproject
{
    class Program
    {
        static void Main(string[] args)
        {

            string Firstname;
            Console.Write("Enter Your Firstname :");
            Firstname = Console.ReadLine();

            // TypeCasting
            char sec;
            Console.Write("Enter Your Section :");
            sec = Convert.ToChar(Console.ReadLine());

            int Number;
            Console.Write("Enter The Number :");
            Number = Convert.ToInt16(Console.ReadLine());

             int Num;
            Console.Write("Enter The Number :");
            Num = Convert.ToInt16(Console.ReadLine());

            double per;
            Console.Write("Enter The Percentage :");
            per = double.Parse(Console.ReadLine());

            // Basic operators
            int sum = Number + Num;
            int difference = Number - Num;
            int product = Number * Num;
            double quotient = Num != 0 ? Number / (double)Num : 0;
            int remainder = Num != 0 ? Number % Num : 0;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}