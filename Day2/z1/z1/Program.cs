double e = 2.71828182846;
double y;
Console.WriteLine("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
if (x <= 2 && x >= 1) {
    y = Math.Pow(x, 2) * Math.Log(x);
    Console.Write($"Ответ: {y}");
}
else if (x < 1)
{
    y = 1;
    Console.Write($"Ответ: {y}");
}
else if (x > 2)
{
    y=Math.Pow(e,2*x)*Math.Cos(5*x);
    Console.Write($"Ответ: {y}");

}