using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues10.Classes;

namespace FIFOQueue12.Classes
{
    public class Animal
    {
        public string Value { get; set; }
        public Animal Next { get; set; }

        public Animal(string value)
        {
            Value = value;
        }

    }
}