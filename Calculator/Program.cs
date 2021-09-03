using System;

namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Operator Type(Ex: + - * /)");
            string OperatorType = Console.ReadLine();
            Console.WriteLine("Please Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (OperatorType == "+") 
            {
                int sum = num1 + num2;
                Console.WriteLine("Total sum = " + sum);
            }
            else if (OperatorType == "-")
            {
                int sum = num1 - num2;
                Console.WriteLine("Total sum = " + sum);
            }
            else if (OperatorType == "*")
            {
                int sum = num1 * num2;
                Console.WriteLine("Total sum = " + sum);
            }
            else if (OperatorType == "/")
            {
                int sum = num1 / num2;
                Console.WriteLine("Total sum = " + sum);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}
