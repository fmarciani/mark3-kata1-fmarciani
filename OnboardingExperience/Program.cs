using System;

namespace OnboardingExperience
{
    class Program
    {
        public static void Main(string[] args)
        {
            var user = new User();

            user.IsAccountOwner = AskBoolQuestion("\nHello! Before we can create your account, we need some information from you. Are you the account owner? Please enter y for yes or n for no.");

            if (!user.IsAccountOwner)
            {
                Environment.Exit(-1);
            }

            user.FirstName = AskQuestion("\nWelcome, and thank you for choosing IntelliBank! Let's get your account set up. What is your first name?");
            user.LastName = AskQuestion($"\nHi there, {user.FirstName}! Now we need to grab your last name. Go ahead and type it below.");

            Console.WriteLine($"\nGotcha! Your name is {user.FullName}. Let's keep going. Press any key to continue:");
            Console.ReadKey(true);

            user.Age = AskIntQuestion("\nNext, we'll need to know your age. Please enter it as a number (e.g., 25).", 2);
            Console.WriteLine($"\nCool! You're {user.Age} years old. Press any key to move on.");
            Console.ReadKey(true);

            user.PIN = AskIntQuestion($"\nNow we're going to have you enter a 4-digit PIN to help protect your account. This can be any number that's easy for you to remember, but please don't choose a PIN that isn't easy to guess (e.g., 2222, 1234). Go ahead and enter your chosen PIN now, {user.FirstName}!", 4);
            Console.WriteLine($"\nYou chose **** as your PIN. (Don't worry; we won't tell.) You'll need to reenter it every time you log into your account, so don't lose it! Press any key to keep going.");
            Console.ReadKey(true);

            user.SecurePhrase = AskQuestion($"\nHuff, puff; we're almost done here! Final round: Let's add a security phrase to your account for extra security! It can be anything (again, we won't tell), but you'll have to type it EXACTLY the way you do here each time you log in. You've got this, {user.FirstName}. Go ahead and enter your phrase below.");
            Console.WriteLine($"\nHey, hey! Look who's good to go. We've got your name, age, PIN, and security phrase ({user.SecurePhrase}), in case you forgot). We won't get more personal than that. Thanks again for banking with IntelliBank! Press any key to exit the app.");
            Console.ReadKey(true);
            Environment.Exit(-1);
        }

        public static bool AskBoolQuestion(string question)
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
                    Console.ReadKey(true);
                    return false;
                }
                else
                {
                    Console.WriteLine("\nInvalid input!");
                }
            }
        }

        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            var answer = Console.ReadLine();

            if (answer.Length == 0)
            {
                return "Julian McBoolean";
            }

            else
            {
                return answer;
            }
        }

        public static int AskIntQuestion(string question, int length = 0)
        {
            while (true)
            {
                var answer = AskQuestion(question);

                if (!Int32.TryParse(answer, out var number))
                {
                    Console.WriteLine("\nOops! We need a number.");
                    continue;
                }
                if (length > 0 && answer.Length != length)
                {
                    Console.WriteLine($"\nOops, you didn't enter the correct length! You need {length} digits. Go ahead and try again.");
                    continue;
                }
                return number;
            }
        }
    }
}