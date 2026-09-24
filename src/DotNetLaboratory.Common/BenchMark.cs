using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
//Замер времени для алгоритмов
namespace DotNetLaboratory.Common
{
    public static class BenchMark
    {
        public static TimeSpan Measure(Action action)
        {
            var sw = Stopwatch.StartNew();
            action();
            sw.Stop();
            return sw.Elapsed;
        }
        public static (T Result, TimeSpan Elapsed) Measure<T>(Func<T> func)
        {
            var sw=Stopwatch.StartNew();
            var result = func();
            sw.Stop();
            return (result, sw.Elapsed);
        }
        public static void Compare(string name1, Action a1, string name2, Action a2) 
        {
            var t1 = Measure(a1);
            var t2 = Measure(a2);
            ConsoleHelper.Result($"{name1}", $"{t1.TotalMilliseconds:F2} ms");
            ConsoleHelper.Result($"{name2}", $"{t2.TotalMilliseconds:F2} ms");

            var faster = t1 < t2 ? name1 : name2;
            var ratio=t1<t2? t2.TotalMilliseconds/t1.TotalMilliseconds : t1.TotalMilliseconds/t2.TotalMilliseconds;
            ConsoleHelper.Result("Быстрее", $"{faster} в {ratio:F2}x");
        }
    }
}
