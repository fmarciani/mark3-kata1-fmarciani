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

            Console.WriteLine($"\nGotcha! Your name is {user.FirstName} {user.LastName}. Let's keep going. Press any key to continue:");
            Console.ReadKey(true);

            user.Age = AskIntQuestion("\nNext, we'll need to know your age. Please enter it as a number (e.g., 25).");
            Console.WriteLine($"\nCool! You're {user.Age} years old. Press any key to move on.");
            Console.ReadKey(true);

            user.PIN = AskIntQuestion($"\nNow we're going to have you enter a 4-digit PIN. This can be any number that's easy for you to remember, but\ndon't make it too easy for anyone else (e.g., 2222, 1234) to guess. Go ahead and enter your chosen PIN now,\n{user.FirstName}!");
            Console.WriteLine($"\nYou chose {user.PIN} as your PIN. Don't lose it! You'll need to reenter it every time you log into your account.\nPress any key to keep going.");
            Console.ReadKey(true);
        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        
        static int AskIntQuestion(string num)
        {
            Console.WriteLine(num);
            return Int32.Parse(Console.ReadLine());
        }
    }
}
