Console.Write("Введите первое вещественное число: ");
double  firstNumber= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе вещественное число: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());
double max;
if (firstNumber > secondNumber)
{
    max = firstNumber;
    Console.WriteLine($"Максимальное значение : {max}");
}

if (secondNumber > firstNumber)
{ max = secondNumber;
    Console.WriteLine($"Максимальное значение: {max}");
}

else if (secondNumber == firstNumber)
{
    Console.WriteLine("Числа равны");
}