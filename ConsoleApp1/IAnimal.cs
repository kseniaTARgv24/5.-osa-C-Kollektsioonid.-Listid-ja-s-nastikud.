﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IAnimal
{
    void MakeSound();
}

public class ICat : IAnimal
{
    public override void MakeSound()
    {
        Console.WriteLine("Mjäu!");
    }
}
