using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastermindAssignment
{
    public partial class DifficultyMenu : Form
    {
        // Allows forms to create instances of the difficultyMenu.
        public static DifficultyMenu difficultyMenu;
        // Allows codeLength to be accessed from other forms.
        public int codeLength;
        // Allows guessNumber to be accessed from other forms.
        public int guessNumber;
        public DifficultyMenu()
        {
            InitializeComponent();
            difficultyMenu = this;
           
        }

        public Board Board
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Handles the Click event of the playButton control.
        /// If the selected guess number and secret code length are valid, it will create a new instance of the Board form and show it.
        /// Otherwise, it will show a warning message to the user.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void playButton_Click(object sender, EventArgs e)
        {
            if ((guessNumber == 8 || guessNumber == 10 || guessNumber == 12 || guessNumber == 14 || guessNumber == 16) && (codeLength == 4 || codeLength == 6 || codeLength == 8))
            {
                Hide();
                Board board = new();
                board.Show();
            }
            else
            {
                string title = "Play Button Error";
                string message = "Please only enter numbers that are available for each combo box";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the secretCodeComboBox control.
        /// Sets the value of the codeLength variable based on the selected value in the secretCodeComboBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void secretCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempSecret;

            // Get the selected value in the secretCodeComboBox and parse it to an integer
            tempSecret = int.Parse(secretCodeComboBox.Text);

            // Set the value of codeLength based on the selected value in the secretCodeComboBox
            codeLength = tempSecret switch
            {
                4 => 4,
                6 => 6,
                8 => 8,
                _ => 4,
            };
        }
        /// <summary>
        /// This method handles the selection change event for the guessComboBox.
        /// It sets the number of guesses the player has based on the selected value.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void guessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempGuess;

            tempGuess = int.Parse(guessComboBox.Text);

            // Depending on what the user selected the corresponding value will be assigned.
            guessNumber = tempGuess switch
            {
                8 => 8,
                10 => 10,
                12 => 12,
                14 => 14,
                16 => 16,
                _ => 10,
            };
        }
        /// <summary>
        /// Allows the user to quit the program.
        /// </summary
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public partial class CopyOfDifficultyMenu : Form
    {
        // Allows forms to create instances of the difficultyMenu.
        public static CopyOfDifficultyMenu difficultyMenu;
        // Allows codeLength to be accessed from other forms.
        public int codeLength;
        // Allows guessNumber to be accessed from other forms.
        public int guessNumber;
        public CopyOfDifficultyMenu()
        {
            InitializeComponent();
            difficultyMenu = this;

        }
        /// <summary>
        /// Handles the Click event of the playButton control.
        /// If the selected guess number and secret code length are valid, it will create a new instance of the Board form and show it.
        /// Otherwise, it will show a warning message to the user.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void playButton_Click(object sender, EventArgs e)
        {
            if ((guessNumber == 8 || guessNumber == 10 || guessNumber == 12 || guessNumber == 14 || guessNumber == 16) && (codeLength == 4 || codeLength == 6 || codeLength == 8))
            {
                Hide();
                Board board = new();
                board.Show();
            }
            else
            {
                string title = "Play Button Error";
                string message = "Please only enter numbers that are available for each combo box";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the secretCodeComboBox control.
        /// Sets the value of the codeLength variable based on the selected value in the secretCodeComboBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void secretCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempSecret;

            // Get the selected value in the secretCodeComboBox and parse it to an integer
            tempSecret = int.Parse(secretCodeComboBox.Text);

            // Set the value of codeLength based on the selected value in the secretCodeComboBox
            codeLength = tempSecret switch
            {
                4 => 4,
                6 => 6,
                8 => 8,
                _ => 4,
            };
        }
        /// <summary>
        /// This method handles the selection change event for the guessComboBox.
        /// It sets the number of guesses the player has based on the selected value.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void guessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempGuess;

            tempGuess = int.Parse(guessComboBox.Text);

            // Depending on what the user selected the corresponding value will be assigned.
            guessNumber = tempGuess switch
            {
                8 => 8,
                10 => 10,
                12 => 12,
                14 => 14,
                16 => 16,
                _ => 10,
            };
        }
        /// <summary>
        /// Allows the user to quit the program.
        /// </summary
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
