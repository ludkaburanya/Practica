int initialValue = 1;
int finalValue = 101;
for (int j = initialValue; j <= finalValue; j++)
{
    if (j % 2 != 0)
    {
        Console.Write($" {j} ");
    }
}
Console.WriteLine();

int i = initialValue;
while (i <= finalValue)
{
    if (i % 2 != 0)
        Console.Write($" {i} ");
    i++;
}
Console.WriteLine();

i = initialValue;
do
{
    if (initialValue == finalValue)
        break;
    if (i % 2 != 0)
        Console.Write($" {i} ");
    i++;
}
while (i <= finalValue);
Console.ReadKey();