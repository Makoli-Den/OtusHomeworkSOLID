namespace GuessNumberGame
{
    internal class RandomNumberGenerator : INumberGenerator
    {
        private Random _random = new Random();

        public int GenerateNumber(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}