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
            if(Tools.Contains(userPassword, lowerCase)){
                score++;
            }
            if(Tools.Contains(userPassword, digits)){
                score++;
            }
            if(Tools.Contains(userPassword, specialChars)){
                score++;
            }
            switch(score){
                        case 5:
                        case 4:
                        Console.WriteLine("Strong AF");
                        break;
                        case 3:
                        Console.WriteLine("strong like a child");
                        break;
                        case 2:
                        Console.WriteLine("meh do better");
                        break;
                        case 1:
                        Console.WriteLine("weak sauce");
                        break;
                        default:
                        Console.WriteLine("No. Put a password in you dunce.");
                        break;
            }
            
        }
    }
}
