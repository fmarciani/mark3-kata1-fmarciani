using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.IsAccountOwner = AskBoolQuestion("\nHello! Before we can create your account, we need some information from you. Are you the\naccount owner? Please enter y for yes or n for no.");

            if (!user.IsAccountOwner)
            {
                Environment.Exit(-1);
            }

            user.FirstName = AskQuestion("\nWelcome, and thank you for choosing IntelliBank! Let's get your account set up. What is your first name?");
            user.LastName = AskQuestion($"\nHello, {user.FirstName}! Now we need to grab your last name. Go ahead and type it below.");

            Console.WriteLine($"\nGotcha! Your name is {user.FirstName} {user.LastName}. Let's keep going. Press any key to continue:");
            Console.ReadKey(true);

            user.Age = AskIntQuestion("\nNext, we'll need to know your age. Please enter it as a number (e.g., 25).");
            Console.WriteLine($"\nCool! You're {user.Age} years old. Press any key to move on.");
            Console.ReadKey(true);

            user.PIN = AskIntQuestion($"\nNow we're going to have you enter a PIN. This can be any number that's easy for you to remember, but\nwe recommend choosing a PIN of at least 4 numbers that aren't easy to guess (e.g., 2222, 1234). Go ahead and enter your chosen PIN now,\n{user.FirstName}!");
            Console.WriteLine($"\nYou chose {user.PIN} as your PIN. Don't lose it! You'll need to reenter it every time you log into your account.\nPress any key to keep going.");
            Console.ReadKey(true);

        }

        static bool AskBoolQuestion(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                var response = Console.ReadLine().ToLower();

                if (response == "y" || response == "yes")
                {
                    Console.WriteLine("\nGreat! Press any key to continue.");
                    Console.ReadKey(true);
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    Console.WriteLine("\nSorry! Only account owners can set up their accounts online. Press any key to exit the app.");
                    return false;
                }
                else
                {
                    Console.WriteLine("\nInvalid input! Please enter y for yes or n for no.");
                }
            }
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
    }
}
