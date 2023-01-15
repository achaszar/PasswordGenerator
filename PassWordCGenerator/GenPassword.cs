using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCGenerator
{
    public class GenPassword
    {
        public string RandomPassword(int length, bool WantUpper, bool WantLower, bool WantNumbers, bool WantSymbols)
        {
            const string UpperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string LowerLetters = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "1234567890";
            const string symbols = ".?!+-[]{}@$*";

            string myPassword = "";

            if (WantUpper)
            {
                myPassword += UpperLetters;

            }
            if (WantLower)
            {
                myPassword += LowerLetters;

            }
            if (WantNumbers)
            {
                myPassword += numbers;

            }
            if (WantSymbols)
            {
                myPassword += symbols;

            }

            Random random = new Random();
            char[] chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = myPassword[random.Next(0, myPassword.Length)];
            }
            return new string(chars);
        }
    }
}
