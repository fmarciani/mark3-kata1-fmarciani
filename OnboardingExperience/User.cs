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
        public string FullName => $"{FirstName} {LastName}".Trim();
        public int Age { get; set; }
        public int PIN { get; set; }
        public string SecurePhrase { get; set; }

    }
}
