using DotNetLaboratory.Common;

namespace DotNetLaboratory.Patterns.Examples;

public class HelloWorldExample : IExample
{
    public string Name => "Hello, Lab!";
    public string Description => "Проверка, что механизм работает.";

    public void Run()
    {
        ConsoleHelper.Info("Лаборатория запущена.");
        ConsoleHelper.Result("Сейчас", DateTime.Now);

        var arr = DataGenerator.RandomIntArray(10);
        ConsoleHelper.Result("Случайный массив", string.Join(", ", arr));

        var time = BenchMark.Measure(() =>
        {
            var sum = 0;
            for (int i = 0; i < 100000; i++) sum += i;
        });
        ConsoleHelper.Result("Потрачено", $"{time.TotalMilliseconds:F2} ms");
    }
}