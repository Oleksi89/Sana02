using System;
class PointsAverage
{
    static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введіть оцінку " + (i + 1) + ": ");
            sum += Convert.ToInt32(Console.ReadLine());
        }
        double average = sum / 5.0;
        if (average >= 50)
        {
            Console.WriteLine("Студент допущений до екзамену");
        }
        else
        {
            Console.WriteLine("Студент не допущений до екзамену");
        }
        Console.ReadLine();
    }
}