using System.Text;
using Common.Menu;
using ConsoleHelpers.Core;
using DataAccess.Accentuations;
using Microsoft.Extensions.Configuration;

namespace DbConsoleConnector;

public class Program
{
    private const string UserNameConfigKey = "UserName";
    private const string UserPasswordConfigKey = "UserPassword";
    private const string ConnectionStringConfigKey = "ConnectionString";
    
    private static IAccentuationsRepository _accentuations = default!;
    private static readonly Menu _menu = new("Взаємодія з БД наголосів через консоль", new[]
    {
        new Option("Пошук дублікатів у БД", FindDuplicates),
        new Option("Визначення наголосів у словах на основі БД", FindSpecificWords),
        new Option("Вийти", Exit)
    });
    
    public static void Main()
    {
        Init();
    
        while(true)
            _menu.Launch();
        // ReSharper disable once FunctionNeverReturns
    }

    private static void Init()
    {
        var config = BuildAppConfig();
        InitConsole();
        InitAccentuationsRepository(config);
    }

    private static void FindSpecificWords()
    {
        while (true)
        {
            Console.WriteLine("Яке слово шукаємо?('0' закриє програму)");
            var find = Console.ReadLine();
            if (find == "0") return;

            var result = _accentuations.GetAccentuation(find);

            if (result is null)
            {
                Console.WriteLine("Не знайдено такого слова в БД.");
                continue;
            }

            Console.Write($"У слова {result.Word} наголос падає на такі склади:");
            result.Accentuations.ForEach(x => Console.Write(x + " "));
            Console.WriteLine(".");
        }
    }

    private static void FindDuplicates()
    {
        Console.WriteLine("Пошук слів-дублікатів...");
        var all = _accentuations.GetAll();
        var duplicated = all
            .GroupBy(accentuation => accentuation.Word)
            .Where(group => group.Count() > 1)
            .Select(group => group.Key)
            .ToList();

        if (duplicated.Any())
        {
            Console.WriteLine("Слова-дублікати:");
            duplicated.ForEach(Console.WriteLine);
        }
        else
        {
            Console.WriteLine("Слова дублікати не знайдені.");
        }
        
        Console.WriteLine("\nНатисніть будь-яку клавішу для продовження.");
        Console.ReadLine();
    }

    private static void Exit() =>
        Environment.Exit(Environment.ExitCode);

    private static void InitConsole()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
    }

    private static IConfigurationRoot BuildAppConfig() =>
        new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();

    private static void InitAccentuationsRepository(IConfiguration configuration) =>
        _accentuations = new AccentuationRepository(new(
            configuration[ConnectionStringConfigKey]!,
            configuration[UserNameConfigKey]!,
            configuration[UserPasswordConfigKey]!));
}