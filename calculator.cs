using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator in C#");
        Console.WriteLine("------------------------");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        bool valid = true;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    valid = false;
                }
                break;

            default:
                Console.WriteLine("Invalid operator.");
                valid = false;
                break;
        }

        if (valid)
        {
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
