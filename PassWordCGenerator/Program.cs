using System;

namespace PasswordCGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            GenPassword newPass = new GenPassword();
            Console.WriteLine($"Your random password is: {newPass.RandomPassword(12, true, true, true, true)}");
        }
    }
}