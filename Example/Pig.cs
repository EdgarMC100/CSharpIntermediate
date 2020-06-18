using System;

namespace Example
{
    partial class Program
    {
        class Pig : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }


    }
}
