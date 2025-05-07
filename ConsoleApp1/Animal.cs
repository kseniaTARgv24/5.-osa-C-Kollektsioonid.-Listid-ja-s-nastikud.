using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal
    {
    public string AnimalName;
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
    public abstract void MakeSound();

}
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{AnimalName}: meow");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{AnimalName}: uh");
    }
}
