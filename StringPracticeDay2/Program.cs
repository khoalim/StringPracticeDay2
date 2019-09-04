using System;

namespace StringPracticeDay2
{
    class Program
    {
        static void Main(string[] args)
        {         

            Console.WriteLine("What is your first name?");
            
            string firstName;
            firstName = Console.ReadLine(); // This is a METHOD it has a () with no parameters defined = is an assignment operator

            Console.WriteLine("Your name is: " + firstName);

            Console.WriteLine("What is your last name?");

            string lastName;
            lastName = Console.ReadLine();

            
            Console.WriteLine("Your name is: " + firstName.ToLower() + " " + lastName.ToLower()); // .ToLower to change case

            Console.WriteLine("Which name is longer?");

            int firstNameLength = firstName.Length;

            int lastNameLength = lastName.Length;

            Console.WriteLine("First Name has " + firstNameLength + " characters");

            Console.WriteLine("Last Name has " + lastNameLength + " characters");




                        

            

        }
    }
}
