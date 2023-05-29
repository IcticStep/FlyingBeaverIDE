using System.Text;
using DataAccess.Accentuations;
using Microsoft.Extensions.Configuration;

namespace DbTester;

public class Program
{
    private const string UserNameConfigKey = "UserName";
    private const string UserPasswordConfigKey = "UserPassword";
    private const string ConnectionStringConfigKey = "ConnectionString";
    
    private static IAccentuationsRepository _accentuations = default!;
    
    public static void Main()
    {
        Init();
        
        while (true)
        {
            Console.WriteLine("Яке слово шукаємо?('0' закриє програму)");
            var find = Console.ReadLine();
            if(find == "0") return;
            
            var result = _accentuations.GetAccentuation(find);

            if (result is null)
            {
                Console.WriteLine("Не знайдено такого слова в БД.");
                continue;
            }

            Console.Write($"У слова {result.Word} наголос падає на такі склади:");
            result.Accentuations.ForEach(x => Console.Write(x+" "));
            Console.WriteLine(".");
        }
    }

    private static void Init()
    {
        var config = BuildAppConfig();
        InitConsole();
        InitAccentuationsRepository(config);
    }

    private static IConfigurationRoot BuildAppConfig() =>
        new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();

    private static void InitConsole()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
    }

    private static void InitAccentuationsRepository(IConfiguration configuration) =>
        _accentuations = new AccentuationRepository(new(
            configuration[ConnectionStringConfigKey]!,
            configuration[UserNameConfigKey]!,
            configuration[UserPasswordConfigKey]!));
}