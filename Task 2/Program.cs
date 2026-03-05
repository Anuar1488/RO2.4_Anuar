using System;

class MainClass
{
    static void Main()
    {

        Console.WriteLine("Exercise 1");
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("the first number is greater than the second");
        }
        else if (num2 > num1)
        {
            Console.WriteLine("the first number is less than the second");
        }
        else
        {
            Console.WriteLine("the numbers are equal");
        }

        Console.WriteLine("Exercise 2");
        Console.Write("Enter the number: ");
        int num3 = int.Parse(Console.ReadLine());

        if (5 < num3 && num3 < 10)
        {
            Console.WriteLine("The number is greater than 5 and less than 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine("Exercise 3");
        Console.Write("Enter the number: ");
        int num4 = int.Parse(Console.ReadLine());


        if (num4 == 5 || num4 == 10)
        {
            Console.WriteLine("The number is either 5 or 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine("Exercise 4");
        Console.Write("Enter the number: ");
        double num5 = Convert.ToDouble(Console.ReadLine());

        double f;

        if (num5 < 100)
        {
            f = 0.05;
        }
        else if (num5 >= 100 && num5 <= 200)
        {
            f = 0.07;
        }
        else
        {
            f = 0.10;
        }

        double total = num5 + num5 * f;
        Console.WriteLine(total);

        Console.WriteLine("Exercise 5");
        Console.Write("Enter the number: ");
        double num6 = Convert.ToDouble(Console.ReadLine());

        double t;

        if (num6 < 100)
        {
            t = 0.05;
        }
        else if (num6 >= 100 && num6 <= 200)
        {
            t = 0.07;
        }
        else
        {
            t = 0.10;
        }
        double bonus = 15;

        double total2 = num6 + num6 * t + bonus;
        Console.WriteLine(total2);


        Console.WriteLine("Exercise 6");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.Write("Enter operation number: ");
        int m = int.Parse(Console.ReadLine());


        switch (m)
        {
            case 1:
                Console.WriteLine("Addition");
                break;

            case 2:
                Console.WriteLine("Subtraction");
                break;

            case 3:
                Console.WriteLine("Multiplication");
                break;

            default:
                Console.WriteLine("the operation is undefined");
                break;
        }


        Console.WriteLine("Exercise 7");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.Write("Enter operation number: ");
        int o = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        switch (o)
        {
            case 1:
                Console.WriteLine($"Addition: {a} + {b} = {a + b}");
                break;

            case 2:
                Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
                break;

            case 3:
                Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
                break;

            default:
                Console.WriteLine("the operation is undefined");
                break;
        }

    }
}
