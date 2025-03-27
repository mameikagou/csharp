// 在不使用顶层语句的情况下，使用命名空间
namespace ConsoleApp1;

// 不使用顶层Main语法糖
public class Program
{
    public static void Main()
    {
        var dog = new Dog("Rex");
        var trainer = new AnimalTrainer();
        trainer.Train(dog);
    }
}

// 接口的优势：
// 多态性：一个方法可以处理不同类型的对象
// 解耦：代码依赖于抽象而不是具体实现
// 可扩展性：容易添加新的实现类

// 接口定义了一组方法签名
// 不包含实现代码
// 通常以"I"开头命名
public interface IAnimal
{
    void MakeSound();
    string GetName();
}

public class Dog : IAnimal
{
    private string Name { get; } // 只读

    public Dog(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine("汪汪汪");
    }

    public String GetName()
    {
        return Name;
    }
}

public class AnimalTrainer
{
    public void Train(IAnimal animal)
    {
        Console.WriteLine($"Training {animal.GetName()}");
        animal.MakeSound();
    }
}