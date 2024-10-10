namespace GuessNumberGame
{
    internal interface IUserInterface
    {
        void ShowMainMessage(string message);
        void ShowMessage(string message);
        void UpdateCounter(int counter);
        bool TryGetUserInput(out int result);
    }
}