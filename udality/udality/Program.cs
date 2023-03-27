using System.Text.RegularExpressions;

Console.Write("Введите текст: ");
string text = Console.ReadLine();

Regex regex = new Regex(@"[бвгджзйклмнпрстфхцчшщ](\w{1})\1{1,1}");
MatchCollection words = regex.Matches(text);

if (words.Count > 0)
{
    foreach (Match word in words)
    {
        Console.WriteLine(word.Value);
    }
}
else
{
    Console.WriteLine("Слов с дефисом не найдено");
}