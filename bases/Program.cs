// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// 接口（Interfaces）
public interface IAnimal
{
    void MakeSound();
    string GetName();
}

// 委托和事件（Delegates and Events）
public delegate void EventHandler(object sender, EventArgs e);

public class Button
{
    public event EventHandler Click;
}

// LINQ（Language Integrated Query）
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0);

// 异步编程（async/await）
public async Task<string> GetDataAsync()
{
    await Task.Delay(1000);
    return "Data";
}

// 泛型（Generics）
public class List<T>
{
    private T[] items;
    // 实现细节
}

var dog = new Dog("Rex");
var trainer = new AnimalTrainer();
trainer.Train(dog);