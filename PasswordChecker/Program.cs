using System;
using System.Net.NetworkInformation;

namespace PasswordChecker
{

    public class Tools
    {
        public Tools()
        {
        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

        public static void ContainsTest()
        {
            string loudWord = "LASDAD";
            string quietWord = "pssst";
            string mixedWord = "lkaAWEkasfkEW";

            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("Running \"tests...\"");
            Console.WriteLine($"Should be true: {Contains(loudWord, uppercase)}");
            Console.WriteLine($"Should be false: {Contains(loudWord, lowercase)}");
            Console.WriteLine($"Should be false: {Contains(quietWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(quietWord, lowercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, lowercase)}");

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Project: Password Checker");
            Console.WriteLine("Welcome to the password checker!");
            int minLength = 10;
            string uppercase = "UPPERCASE";
            string lowercase = "lowercase";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*";

            while (true)
            {

                Console.WriteLine("Enter a password and I will tell you if it is strong!");
                string password = Console.ReadLine();

                int score = 0;
                if (password.Length >= minLength)
                {
                    score++;
                    Console.WriteLine($"Your password meets the minimum length requirements! Your score is now {score}");
                }

                if (Tools.Contains(password, uppercase))
                {
                    score++;
                    Console.WriteLine($"Your password has an uppercase letter! Your score is now {score}");
                }

                if (Tools.Contains(password, lowercase))
                {
                    score++;
                    Console.WriteLine($"Your password has a lowercase letter! Your score is now {score}");
                }

                if (Tools.Contains(password, digits))
                {
                    score++;
                    Console.WriteLine($"Your password contains digits! Your score is now {score}");
                }

                if (Tools.Contains(password, specialChars))
                {
                    score++;
                    Console.WriteLine($"Your password contains a special character! Your score is now {score}");
                }

                switch (score)
                {
                    case 1:
                        Console.WriteLine("Your password is weak, try adding more.");
                        break;
                    case 2:
                        Console.WriteLine("Your password is medium, more can be added to make it stronger.");
                        break;
                    case 3:
                        Console.WriteLine("Your password is strong, but it can be stronger.");
                        break;
                    case 4:
                    case 5:
                        Console.WriteLine("Your password is extremely strong, nice work!");
                        break;
                    default:
                        Console.WriteLine("Your password does not meet the standards, please try again.");
                        break;
                }

                Console.WriteLine("Would you like to test another password?(Y/N)");
                string checkAnother = Console.ReadLine().ToUpper();
                if (checkAnother == "Y")
                {
                    continue;
                }

                else if (checkAnother == "N")
                {
                    Console.WriteLine("Thank you! Have a great day!");
                    return;
                }
            }
        }
    }
}
    

