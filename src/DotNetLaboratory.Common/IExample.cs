namespace DotNetLaboratory.Common;
//Контракт для запускаемого примера в лаборатории
public interface IExample
{
    string Name {  get; }
    string Description { get; } //описание примера
    void Run();//Демонстрация
}
