﻿using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.IsAccountOwner = AskBoolQuestion("\nWelcome, and thank you for choosing IntelliBank! Before we can create your account, we need some information from you.\nAre you the account owner? Please enter y for yes or n for no.");

            if (!user.IsAccountOwner)
            {
                Console.WriteLine("\nSorry! Only account owners can set up their accounts online. Press any key to exit the app.");
                Console.ReadKey(true);
                return;
            }

            user.FirstName = AskQuestion("\nGreat! Let's get your account set up. What's your first name?");
            user.LastName = AskQuestion($"\nHi there, {user.FirstName}! Now we need to grab your last name. Go ahead and type it below.");

            Console.WriteLine($"\nSuccess! Your name is {user.FullName}. Let's keep going. Press any key to continue:");
            Console.ReadKey(true);

            // Code discriminates against centenarians and elementary schoolers.
            user.Age = AskIntQuestion($"\nUh, oh; it's time to get personal, {user.FullName}: We need to know your age. Please enter it as a number (e.g., 25).", 2);
            Console.WriteLine($"\nYou're {user.Age} years young, and a captive audience to our dad jokes. Press any key to move on.");
            Console.ReadKey(true);

            user.PIN = AskIntQuestion($"\nNow we're going to have you enter a 4-digit PIN to help protect your account. Try not to choose a PIN that's too easy\nto guess (e.g., 2222, 1234), and don't lose it! You'll need to reenter it every time you log into your account. Go\nahead and enter your chosen PIN now, {user.FirstName}!", 4);
            Console.WriteLine($"\nYou chose **** as your PIN. (Don't worry; we won't tell.) Press any key to keep going.");
            Console.ReadKey(true);

            user.SecurePhrase = AskQuestion($"\nHuff, puff; we're almost done here! Final round: Let's add a security phrase to your account. It can be anything, but\nyou'll have to type it EXACTLY the way you do here each time you log in. You've got this, {user.FirstName}. Go ahead and enter your\nphrase below.");
            Console.WriteLine($"\nHey, hey! Look who's good to go. Don't worry, we're done getting personal. Thanks again for choosing IntelliBank!");

            Console.WriteLine("\nPress any key to exit!");
            Console.ReadKey(true);
        }

        public static bool AskBoolQuestion(string question)
        {
            // While method is engaged, it responds to questions about whether the app user is the account owner or not.
            while (true)
            {
                Console.WriteLine(question);
                var response = Console.ReadLine().ToLower();

                if (response == "y" || response == "yes")
                {
                    return true;
                }

                // If the user isn't the account owner, they're prompted to press a key and terminate the app.
                else if (response == "n" || response == "no")
                {
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

            // For all those users who think they can get past me by throwing me blank answers.
            if (answer.Length == 0)
            {
                return "Doot";
            }

            else
            {
                return answer;
            }
        }

        public static int AskIntQuestion(string question, int length = 0)
        {
            // While the method is engaged, it responds to either questions about age or PIN by parsing numbers from strings.
            while (true)
            {
                var answer = AskQuestion(question);

                // If a number can't be parsed from the string, the program presses for a number.
                if (!Int32.TryParse(answer, out var number))
                {
                    Console.WriteLine("\nOops! We need a number.");
                    continue;
                }

                /* If the number doesn't equal the exact number of digits specified when the method is called, the user is
                prompted to enter an answer with the correct digit length. */
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