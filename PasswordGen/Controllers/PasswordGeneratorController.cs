using Microsoft.AspNetCore.Mvc;
using PasswordGen.Models;

namespace PasswordGen.Controllers
{
    public class PasswordGeneratorController : Controller
    {
        public IActionResult Index()
        {
            GenPasswordViewModel password= new GenPasswordViewModel();
            return View(password);
        }
        public IActionResult GeneratePassword(int length, bool wantUpper, bool wantLower, bool wantNumbers, bool wantSymbols)
        {
            GenPasswordViewModel genPasswordModel = new GenPasswordViewModel();
            const string UpperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string LowerLetters = "abcdefghijklmnopqrstuvwxyz";
            const string Numbers = "01234567899876543210";
            const string Symbols = ".?!+-[]{}@$*.?!+-[]{}@$*";

            string myPassword = "";
            string passwordResult = "";
            string DefaultPassword = "RunnerRunner321";

            if (wantUpper)
            {
                myPassword += UpperLetters;
            }

            if (wantLower)
            {
                myPassword+= LowerLetters;
            }
            
            if (wantNumbers)
            {
                myPassword += Numbers;
            }

            if (wantSymbols)
            {
                myPassword += Symbols;
            }

            else
            {
                myPassword += DefaultPassword;
            }

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                char letter = myPassword[random.Next(0, myPassword.Length)];
                passwordResult += letter;
            }
            genPasswordModel.PasswordResult = passwordResult;
            return View("Index", genPasswordModel);

        }
    }
}
