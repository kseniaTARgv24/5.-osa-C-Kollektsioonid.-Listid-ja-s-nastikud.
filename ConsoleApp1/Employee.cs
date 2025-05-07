using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee : Person
{
    public string WorkPlace;

    public void IWork()
    {
        Console.WriteLine($"{Name} works at {WorkPlace}");
    }
}
