namespace ConsoleHelpers.Core;

public class ConsoleHelperWorker<THelper> 
    where THelper : ILinearHelper, new()
{
    private static string? _inputFilePath;
    private static string? _outputFilePath;
    private static string _input;
    private static string _output;
    private static readonly ILinearHelper _helper = new THelper();
    
    public void Run()
    {
        GetSettingsFromUser();
        TryGetInput();
        ProceedConversion();
        TrySaveResult();
        
        Console.WriteLine("Робота виконана успішно!");
    }
    
    private static void GetSettingsFromUser()
    {
        Console.WriteLine("Введіть абсолютний шлях до початкового файлу:");
        _inputFilePath = Console.ReadLine();
        Console.WriteLine("Введіть абсолютний шлях до файлу результату:");
        _outputFilePath = Console.ReadLine();
    }

    private static void TryGetInput()
    {
        try
        {
            _input = LoadFromFile(_inputFilePath!);
        }
        catch(Exception exception)
        {
            Console.WriteLine($"Помилка читання файлу початкових даних. Проблема: {exception.Message}.");
            Environment.Exit(Environment.ExitCode);
        }
    }

    private static void ProceedConversion()
    {
        Console.WriteLine("Робота в процесі...");
        _helper.Input = _input;
        _helper.Proceed();
        _output = _helper.Output;
    }

    private static void TrySaveResult()
    {
        try
        {
            SaveDataToFile(_output, _outputFilePath);
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Відбулася помилка при збережені файлу. Деталі помикли:{exception.Message}.");
            Environment.Exit(Environment.ExitCode);
        }
    }

    public static string LoadFromFile(string path)
    {
        using var reader = new StreamReader(path);
        return reader.ReadToEnd();
    }

    private static void SaveDataToFile(string data, string path)
    {
        using var fileStream = new FileStream(path, FileMode.Create);
        using var writer = new StreamWriter(fileStream);
        writer.WriteLine(data);
    }
}