using System;

namespace ConsoleApplication1
{
    class Class1
    {
        static void F(double a, double b, double m)
        {
            Console.WriteLine("Введите расстояние в см: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double h = (b - a) / m;
            for (double i = a; i <= b; i += 0.1)
            {
                Console.WriteLine(x-Math.Sin(x));
                x += h;
            }
        }
        static void Main()
        {
            F(0, Math.PI / 2, 10);
        }
    }
}