using System;

namespace InterfaceLastExercises
{
    public class DbStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Changing the status of the video recording");
        }
    }
}
