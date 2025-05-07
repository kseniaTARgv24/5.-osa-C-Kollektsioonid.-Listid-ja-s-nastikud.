using System;
using System.Xml.Linq;

class Lesson
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Tom";
        p.Age = 25;
        p.Greet();

        Employee e = new Employee();
        e.WorkPlace = "tthk";
        e.Name = "Tom";
        e.IWork();

        Cat a = new Cat();
        a.AnimalName = "Cat";
        a.MakeSound();


        Dog d = new Dog();
        d.AnimalName = "Dog";
        d.MakeSound();
        d.Eat();

        ICat s = new ICat();
        s.MakeSound();

        Bank b = new Bank();
        b.Saldo = -50;

        Bank c = new Bank();
        c.Saldo = 50;

         




    }
}