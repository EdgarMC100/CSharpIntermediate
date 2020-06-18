using System;

namespace InterfaceLastExercises
{
    public class EmailService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Executing sending email notification....");
        }
    }
}
