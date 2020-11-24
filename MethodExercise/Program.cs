using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
           
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
           
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            
            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

           Console.WriteLine($"So {name} you like {color} {animal}s that listen to {band}.");

        }
    }
}


    
