namespace GuessNumberGame
{
    internal class GameLogic
    {
        private readonly INumberGenerator _numberGenerator;
        private readonly IUserInterface _userInterface;
        private readonly GameSettings _gameSettings;
        private int _targetNumber = 0;
        private int _attempts = 0;
        private bool _guessed = false;

        public GameLogic(INumberGenerator numberGenerator, IUserInterface userInterface, GameSettings gameSettings)
        {
            _numberGenerator = numberGenerator;
            _userInterface = userInterface;
            _gameSettings = gameSettings;
            _targetNumber = _numberGenerator.GenerateNumber(_gameSettings.MinNumber, _gameSettings.MaxNumber);
        }

        public void GuessNumber()
        {
            if (_attempts < _gameSettings.MaxAttempts - 1 && !_guessed)
            {
                int userGuess;
                if (_userInterface.TryGetUserInput(out int userInput))
                {
                    userGuess = userInput;
                }
                else
                {
                    _userInterface.ShowMessage("Не получилось считать число. Возможно, вы ввели что-то не так?");
                    return;
                }

                _attempts++;
                _userInterface.UpdateCounter(_gameSettings.MaxAttempts - _attempts);

                if (userGuess < _targetNumber)
                {
                    _userInterface.ShowMessage("Загаданное число больше.");
                    return;
                }
                else if (userGuess > _targetNumber)
                {
                    _userInterface.ShowMessage("Загаданное число меньше.");
                    return;
                }
                else
                {
                    _userInterface.ShowMessage("Поздравляем! Вы угадали.");
                    _guessed = true;
                    return;
                }
            }

            if (!_guessed)
            {
                _userInterface.ShowMessage($"Вы проиграли! Загаданное число было {_targetNumber}.");
                _userInterface.UpdateCounter(0);
                return;
            }
        }
    }
}