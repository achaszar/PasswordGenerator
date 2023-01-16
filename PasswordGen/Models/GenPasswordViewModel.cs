namespace PasswordGen.Models
{
    public class GenPasswordViewModel
    {
        public int Length { get; set; }
        public bool WantUpper { get; set; }
        public bool WantSymbols { get; set; }
        //Create passwordResult with default
        public string PasswordResult { get; set; } = "RunnerRunner321";
    }
}
