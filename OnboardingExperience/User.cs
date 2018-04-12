using System;
using System.Collections.Generic;
using System.Text;

namespace OnboardingExperience
{
    class User
    {

        public bool IsAccountOwner { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PIN { get; set; }

        /*static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }*/

        //static int AskIntQuestion(int age)
    }
}
