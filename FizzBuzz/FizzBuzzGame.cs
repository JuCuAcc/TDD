namespace FizzBuzz
{
    public static class FizzBuzzGame
    {
        public static string Play(int number)
        {
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }
    }
}