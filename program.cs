using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySecondProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How long should your password be?");
        int userPasswordLength;
        bool success = int.TryParse(Console.ReadLine(), out userPasswordLength);

        if (success)
        {
            string userPasswordLengthString = userPasswordLength.ToString();
            Console.WriteLine("The user password length is: " + userPasswordLengthString);

            Password password = new Password();
            string generatedPassword = password.passwordGen(userPasswordLength);
            Console.WriteLine("Generated password: " + generatedPassword);
        }
        else
        {
            Console.WriteLine("Invalid input, please enter an integer.");
        }
       
    }
}