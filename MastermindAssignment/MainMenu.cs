namespace MastermindAssignment
{
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Initilize the MainMenu Form.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        public HelpMenu HelpMenu
        {
            get => default;
            set
            {
            }
        }

        public DifficultyMenu DifficultyMenu
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Button that shows the difficulty menu and hides the main menu.
        /// </summary>
        private void startButton_Click(object sender, EventArgs e)
        {
            DifficultyMenu difficultyMenu = new();
            difficultyMenu.Show();
            Hide();
        }
        /// <summary>
        /// Button that shows the help menu and hides the main menu.
        /// </summary>
        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpMenu helpMenu = new();
            helpMenu.Show();
            Hide();
        }
        /// <summary>
        /// Quits the program.
        /// </summary>
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}