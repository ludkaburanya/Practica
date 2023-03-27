Console.WriteLine("Введите N ( 1<= N <=10 ): ");
int n = Convert.ToInt32(Console.ReadLine());
int finalValue = n * 2;
int step = n;
double sum=0;
while(step < finalValue)
{
    double numberSquared = Math.Pow(step, 2);
    Console.WriteLine($"{step} in square = { numberSquared}");
    sum += numberSquared;
    step++;
    Console.WriteLine($"Sum = {sum}");
}