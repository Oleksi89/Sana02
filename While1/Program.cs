using System;
class While1
{
    static void Main(string[] args)
    {
        Console.Write("Введіть натуральне число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double a = CalculateA(n);
        double b = CalculateB(n);
        double c = CalculateC(n);

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);

        Console.ReadLine();
    }

    static double CalculateA(int n)
    {
        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += Math.Pow(-1, i) / (2.0 * i + 1);
        }
        return sum;
    }

    static double CalculateB(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1 + 1 / Math.Pow(i, 2);
        }
        return sum;
    }

    static double CalculateC(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += Factorial(i);
        }
        return sum;
    }

    static double Factorial(int n)
    {
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}