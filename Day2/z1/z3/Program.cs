Console.WriteLine("Введите набранный балл: ");
int score = Convert.ToInt32(Console.ReadLine());
if (score < 0 || score < 100)
{
    if (score >= 50) 
    {
        if (score >= 70)
        {
            if (score >= 90)
            {
                Console.WriteLine("Отлично");
            }
            else Console.WriteLine("Хорошо");
        }
        else Console.WriteLine("Удовлетворительно");
    }
    else Console.WriteLine("Неудовлетворительно"); 
}
else 
{ 
    Console.WriteLine("ЖЕСТЬ.. что за балл такой");
    Environment.Exit(0);
}
