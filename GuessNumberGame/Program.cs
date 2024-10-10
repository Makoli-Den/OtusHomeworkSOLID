using Microsoft.Extensions.Configuration;

namespace GuessNumberGame
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("gamesettings.json", optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            GameSettings settings = new GameSettings();
            configuration.GetSection("GameSettings").Bind(settings);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameForm(settings));
        }
    }
}