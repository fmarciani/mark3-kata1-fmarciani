using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.FirstName = AskQuestion("\nWelcome, and thank you for choosing IntelliBank! Let's get your account set up. What is your first name?");
            user.LastName = AskQuestion($"\nHello, {user.FirstName}! Now we need to grab your last name. Go ahead and type it below.");

            Console.WriteLine($"\nGotcha! Your name is {user.FirstName} {user.LastName}. Let's keep going. Press any key to continue:");
            Console.ReadKey(true);

            user.Age = AskIntQuestion("\nNext, we'll need to know your age. Please enter it as a number (e.g., 25).");
            Console.WriteLine($"\nCool! You're {user.Age} years old. Press any key to move on.");
            Console.ReadKey(true);

            user.PIN = AskPINQuestion($"\nNow we're going to have you enter a 4-digit PIN. This can be any number that's easy for you to remember, but\ndon't make it too easy for anyone else (e.g., 2222, 1234) to guess. Go ahead and enter your chosen PIN now,\n{user.FirstName}!");
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
            var number = 0;

            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("\nOops, that's not a number! Please return your age in numbers.");
            };

            return number;
        }

        static int AskPINQuestion(string pin)
        {
            Console.WriteLine(pin);

            var PersonalID = 1234;

            if (Console.ReadLine().Length != 4 && !Int32.TryParse(Console.ReadLine(), out PersonalID) {
                Console.WriteLine("\nOops! Please enter your PIN in 4 numbers.");
            }
            else
            {
                Int32.TryParse(Console.ReadLine(), out PersonalID);
                return PersonalID;
            }
        }
    }
}
