using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChars = "~!@#$%^&*?";
            Console.WriteLine("Please enter a password:");
            string userPassword = Console.ReadLine();
            int score = 0;
            if(userPassword.Length >= minLength){
                score ++;
            }
            if(Tools.Contains(userPassword, upperCase)){
                score++;
            }
            Console.WriteLine(score);
        }
    }
}
