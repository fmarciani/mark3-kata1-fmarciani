using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our banking app! Before we get started, we need some information from you. What is your first name?");
            var firstName = Console.ReadLine();

            Console.WriteLine($"\nAwesome! Your first name is {firstName}");
            Console.WriteLine("Now we'll need your last name. Press a key to move on.");
            Console.ReadKey(true);

            Console.WriteLine("\nWhat's your last name?");
            var lastName = Console.ReadLine();

            Console.WriteLine($"\nGreat! Your last name is {lastName}");
            Console.WriteLine("Let's go ahead and move onto the next steps. Press any key to continue.");
            Console.ReadKey(true);
        }
    }


}
