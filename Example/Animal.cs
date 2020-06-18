using System;

namespace Example
{
    partial class Program
    {
        class Animal  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }


    }
}
