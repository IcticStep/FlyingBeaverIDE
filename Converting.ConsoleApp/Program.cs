using System.Text;
using Common.Menu;
using ConsoleHelpers.Core;
using Converting.Logic;

namespace Converting.ConsoleApp;

internal static class Program
{
    private static readonly ConsoleHelperWorker<RawAccentuationsClearer> _rawAccentuationClearer = new();
    private static readonly ConsoleHelperWorker<RawAccentuationToAccentuations> _rawAccentuationsToDomainWorker = new();

    private static readonly Menu _menu = new("Консольні утиліти конвертери", new[]
    {
        new Option("Видалення записів з надмірною довжиною, очистка пробілів", _rawAccentuationClearer.Run),
        new Option("Підготовка наголосів Slovnyk UA до DB", _rawAccentuationsToDomainWorker.Run),
        new Option("Вийти", Exit)
    });

    private static void Main()
    {
        Init();
        while (true)
            _menu.Launch();
        // ReSharper disable once FunctionNeverReturns
    }

    private static void Init()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
    }

    private static void Exit() => Environment.Exit(Environment.ExitCode);
}