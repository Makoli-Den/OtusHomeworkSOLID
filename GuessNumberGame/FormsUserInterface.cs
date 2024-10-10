namespace GuessNumberGame
{
    internal class FormsUserInterface : IUserInterface
    {
        private readonly GameForm _form;

        public FormsUserInterface(GameForm form)
        {
            _form = form;
        }

        public void ShowMainMessage(string message)
        {
            _form.DisplayMainMessage(message);
        }

        public void ShowMessage(string message)
        {
            _form.DisplayMessage(message);
        }

        public void UpdateCounter(int counter)
        {
            _form.UpdateCounter(counter);
        }

        public bool TryGetUserInput(out int result)
        {
            result = 0;
            if (_form.TryGetUserInput(out int userInput))
            {
                result = userInput;
                return true;
            }
            return false;
        }
    }
}