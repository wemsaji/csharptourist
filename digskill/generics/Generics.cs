namespace digskill.generics;

public class Generics
{
    public static void Test()
    {
        int[] integerArray = [1, 2, 3, 4, 5];
        string[] stringArray = ["あ", "い", "う", "え", "お"];
        Animal[] animalsArray = [new Human(), new Cat(), new Dog()];

        PrintArray(integerArray);
        PrintArray(stringArray);
        PrintArray(animalsArray);
    }

    private static void PrintArray<T>(T[] inputArray)
    {
        foreach (T element in inputArray)
        {
            if (element is Animal animal)
            {
                Console.WriteLine(animal.Speak());
                if (element is IHandshakable handshakable)
                {
                    handshakable.Handshake();
                }
            }
            else
            {
                Console.WriteLine(element);
            }
        }
    }
}

public abstract class Animal
{
    public virtual string Speak()
    {
        return "こんにちは";
    }
}

public interface IHandshakable
{
    void Handshake();
}

public class Human : Animal, IHandshakable
{
    public void Handshake()
    {
        Console.WriteLine("固い握手を交わしました。");
    }
}

public class Cat : Animal
{
    public override string Speak()
    {
        return "ニャー";
    }
}

public class Dog : Animal
{
    public override string Speak()
    {
        return "ワン";
    }
}
