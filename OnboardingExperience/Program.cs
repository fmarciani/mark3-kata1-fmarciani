using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            
            user.FirstName = AskQuestion("Welcome to our banking app! Before we get started, we need some information from you. What is your first name?");
            user.LastName = AskQuestion($"\nHello, {user.FirstName}! Now we need to grab your last name. Go ahead and type it below.");

            Console.WriteLine($"\nGreat! Your name is {user.FirstName} {user.LastName}. Let's keep going. Press any key to continue:");
            Console.ReadKey(true);
        }

        static string AskQuestion(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }
    }
}
