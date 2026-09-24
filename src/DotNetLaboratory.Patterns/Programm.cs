using System.Reflection;
using DotNetLaboratory.Common;

var examples = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(t => typeof(IExample).IsAssignableFrom(t)
                && !t.IsInterface
                && !t.IsAbstract)
    .Select(t => (IExample)Activator.CreateInstance(t)!)
    .OrderBy(e => e.Name)
    .ToList();

while (true)
{
    Console.Clear();
    ConsoleHelper.Header("DotNetLaboratory — меню примеров");

    for (int i = 0; i < examples.Count; i++)
    {
        Console.WriteLine($"  [{i + 1}] {examples[i].Name}");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"      {examples[i].Description}");
        Console.ResetColor();
    }

    Console.WriteLine();
    Console.WriteLine("  [0] Выход");
    Console.Write("\nВыбор: ");

    var input = Console.ReadLine();
    if (input == "0") break;

    if (int.TryParse(input, out var choice)
        && choice >= 1 && choice <= examples.Count)
    {
        var example = examples[choice - 1];
        Console.Clear();
        ConsoleHelper.Header(example.Name);
        try
        {
            example.Run();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.ResetColor();
        }
        ConsoleHelper.WaitForEnter();
    }
}