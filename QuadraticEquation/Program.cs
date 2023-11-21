using System;
class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Write("Введіть a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        Console.WriteLine("Дискримінант: " + discriminant);

        if (discriminant < 0)
        {
            Console.WriteLine("Розв'язків немає");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Розв'язок: " + x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Розв'язки: " + x1 + ", " + x2);
        }
        Console.ReadLine();
    }
}