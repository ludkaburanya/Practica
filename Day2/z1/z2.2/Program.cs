Console.Write("Введите a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введитте c: ");
double c = Convert.ToDouble(Console.ReadLine());
double d = Math.Pow(b, 2) - (4 * a * c);
if (d > 0) Console.WriteLine(true);
else Console.WriteLine(false);