using System.Text;
using DataAccess;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

var accentuations = new AccentuationRepository();

while (true)
{
    Console.WriteLine("Яке слово шукаємо?('0' закриє програму)");
    var find = Console.ReadLine();
    var result = accentuations.GetAccentuation(find);

    if (result is null)
    {
        Console.WriteLine("Не знайдено такого слова в БД.");
        continue;
    }

    Console.Write($"У слова {result.Word} наголос падає на такі склади:");
    result.Accentuations.ForEach(x => Console.Write(x+" "));
    Console.WriteLine(".");
}