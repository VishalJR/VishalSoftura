using System;
public class Program
    {
       public static void Main()
        {
            int num1;
            int num2;
            int sum, sub, mult;
            float div;
            Console.WriteLine("Enter first number :");
            num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            sub = num1 - num2;
            mult = num1 * num2;
            div = (float)num1 / num2;
            Console.WriteLine("\nSum of number1 and number2 : " + sum);
            Console.WriteLine("Difference of number1 and number2 : "+ sub);
            Console.WriteLine("Product of number1 and number2 : " + mult);
            Console.WriteLine("Quotient of number1 and number2 : " + div);
        }
    }