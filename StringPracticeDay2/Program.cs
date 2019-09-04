using System;

namespace StringPracticeDay2
{
    class Program
    {
        static void Main(string[] args)
        {         

            Console.WriteLine("What is your first name?");
            
            string firstName;
            firstName = Console.ReadLine(); // This is a METHOD it has a () with no parameters defined , = is an assignment operator

            Console.WriteLine("Your name is: " + firstName);

            Console.WriteLine("What is your last name?");

            string lastName;
            lastName = Console.ReadLine();

            string fullName = firstName.ToLower() + " " + lastName.ToLower(); // .ToLower to change case

            Console.WriteLine("Your full name is: " + fullName);

            
            Console.WriteLine("How many characters does each name have?");

            int firstNameLength = firstName.Length; // Length is a property

            int lastNameLength = lastName.Length;

            Console.WriteLine("First Name has " + firstNameLength + " characters");

            Console.WriteLine("Last Name has " + lastNameLength + " characters");

            Console.WriteLine("Which name is longer?");

            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("Your First Name is longer than your Last Name");
            }

            else
            {
                Console.WriteLine("Your Last Name is longer than your First Name");
            }
                                                        

            

        }
    }
}
