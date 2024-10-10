namespace GuessNumberGame
{
    internal partial class GameForm : Form
    {
        private readonly GameSettings _settings;
        private readonly INumberGenerator _numberGenerator = new RandomNumberGenerator();
        private readonly IUserInterface _userInterface;
        private GameLogic _game;

        public GameForm(GameSettings settings)
        {
            InitializeComponent();
            _settings = settings;
            _userInterface = new FormsUserInterface(this);
            _game = new GameLogic(_numberGenerator, _userInterface, _settings);
            DisplayMainMessage($"Угадайте число от {_settings.MinNumber} до {_settings.MaxNumber}");
            DisplayMessage("");
            UpdateCounter(_settings.MaxAttempts);
        }

        public bool TryGetUserInput(out int result)
        {
            result = 0;
            if (int.TryParse(textBox.Text, out int userInput))
            {
                result = userInput;
                return true;
            }
            return false;
        }

        public void DisplayMainMessage(string message)
        {
            labelMain.Text = message;
        }

        public void DisplayMessage(string message)
        {
            label.Text = message;
        }

        public void UpdateCounter(int attemptCount)
        {
            labelCounter.Text = $"Кол-во попыток: {attemptCount}";
        }

        private void button_Click(object sender, EventArgs e)
        {
            _game.GuessNumber();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            _game = new GameLogic(_numberGenerator, _userInterface, _settings);
            DisplayMainMessage($"Угадайте число от {_settings.MinNumber} до {_settings.MaxNumber}");
            DisplayMessage("");
            UpdateCounter(_settings.MaxAttempts);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-')
            {
                if (textBox.Text.Length > 0 || (textBox.SelectionStart > 0 && !char.IsDigit(textBox.Text[textBox.SelectionStart - 1])))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
