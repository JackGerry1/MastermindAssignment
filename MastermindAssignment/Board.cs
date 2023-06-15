using System.Data;

namespace MastermindAssignment
{
    public partial class Board : Form
    {
        // controls whether the user has won or not.
        private static bool winstate;
        // stores the code length based on the difficulty menu
        private static int codeLength;

        // colorButtonArrayCounter is an integer variable that keeps track of the current index in the userPegs array.
        private int userPegsArrayCounter = 0;

        // attemptsLeft stores the number of attempts the player has left.
        private static int attemptsLeft;

        // attemptsCounter stores the number of guess rows.
        private static int guessRowNumber;

        // counter is an integer variable that is used to keep track of the current index in the submitedPegsStore and cluePegStore arrays.
        private int guessRowPositionTracker;

        // whitePegs is an array of integers that stores the number of white pegs for each attempt.
        private static int[]? whitePegs;

        // cluePegCommands stores the clue pegs (red, white, or gray) for each attempt.
        private static string[]? cluePegCommands;
        // stores int representation of the secret code
        private static int[]? secretCode;

        // Stores the submitted pegs for each attempt.
        private static int[,]? submitedPegsStore;

        // Stores the clue pegs for each attempt.
        private static string[,]? cluePegStore;

        // Stores the pegs the player has currently submitted.
        private static int[]? submitedPegs;

        // userPegs stores the pegs the player has selected.
        private static int[]? userPegs;

        // Generates random numbers for the secret code.
        private readonly Random randomGenerator = new();

        // outputBrush is a SolidBrush object that is used to draw the pegs on the userInputPanel
        private SolidBrush outputBrush = new(Color.Gray);
        // These are the variables used to paint the output pegs with a specifed color.
        private readonly SolidBrush grayBrush = new(Color.Gray);
        private readonly SolidBrush redBrush = new(Color.Red);
        private readonly SolidBrush yellowBrush = new(Color.Yellow);
        private readonly SolidBrush blueBrush = new(Color.DodgerBlue);
        private readonly SolidBrush pinkBrush = new(Color.Fuchsia);
        private readonly SolidBrush greenBrush = new(Color.Lime);
        private readonly SolidBrush purpleBrush = new(Color.Purple);
        private readonly SolidBrush blackBrush = new(Color.Black);
        private readonly SolidBrush whiteBrush = new(Color.White);

        /// <summary>
        /// Initializes the Board form and sets the various class variables based on the difficulty settings chosen in the DifficultyMenu form.
        /// </summary>
        public Board()
        {
            // Set the code length and number of attempts left based on the difficulty menu settings
            codeLength = DifficultyMenu.difficultyMenu.codeLength;
            attemptsLeft = DifficultyMenu.difficultyMenu.guessNumber;

            // Initialize the arrays
            cluePegCommands = new string[codeLength];
            secretCode = new int[codeLength];
            submitedPegsStore = new int[codeLength, attemptsLeft];
            cluePegStore = new string[codeLength, attemptsLeft];
            submitedPegs = new int[codeLength];
            userPegs = new int[codeLength];

            // Set the attempts counter to the number of attempts left
            guessRowNumber = attemptsLeft;

            // Initialize the white pegs array
            whitePegs = new int[codeLength];

            // sets the position to the end of the submitted pegs array based on the guess number - 1 to avoid out of bounds error
            guessRowPositionTracker = DifficultyMenu.difficultyMenu.guessNumber - 1;

            // Set the secret code
            SetSecretCode();

            // Initialize the form components
            InitializeComponent();
        }

        public LoseScreen LoseScreen
        {
            get => default;
            set
            {
            }
        }

        public WinScreen WinScreen
        {
            get => default;
            set
            {
            }
        }

        public CircleButtons CircleButtons
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Generates a random set of numbers, which are converted to strings, which represent the secretCode.
        /// This is stored in the secretCode array.
        /// </summary>
        private void SetSecretCode()
        {
            for (int i = 0; i < secretCode.Length; i++)
            {
                secretCode[i] = randomGenerator.Next(1, 9);
            }
        }
        /// <summary>
        /// Handles the Paint event of the secretPanel control.
        /// Draws ellipses on the secretPanel control to represent the secret code.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="pegs">The instance containing the event data.</param>
        private void secretPanel_Paint(object sender, PaintEventArgs pegs)
        {
            // Draw a white rectangular border around the secretPanel control
            ControlPaint.DrawBorder(pegs.Graphics, secretPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            // Initialize starting x-coordinate for drawing the default circles
            int xcoords = 60;

            // Get the Graphics object for the secretPanel pegs
            Graphics secretCodeGraphics = pegs.Graphics;

            // Loop through elements in secret code array.
            for (int i = 0; i < secretCode.Length; i++)
            {
                // Displays the brush color based on the secret code value when the game has ended.
                if (winstate || attemptsLeft == 0)
                {
                    outputBrush = secretCode[i] switch
                    {
                        1 => redBrush,
                        2 => blueBrush,
                        3 => yellowBrush,
                        4 => greenBrush,
                        5 => purpleBrush,
                        6 => pinkBrush,
                        7 => whiteBrush,
                        8 => blackBrush,
                        _ => grayBrush,
                    };
                }
                // Specify the position and size of the secret code pegs.
                secretCodeGraphics.FillEllipse(outputBrush, xcoords, 15, 30, 30);
                // Default the brush color to gray, whilst the game is not over.
                outputBrush = grayBrush;
                // Displays the next peg 40px to the right.
                xcoords += 40;
            }
        }
        /// <summary>
        /// Handles the Paint event of the userInputPanel control.
        /// Draws ellipses on the userInputPanel control to represent the submitted pegs based on the user's color choices.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="pegs">The instance containing the event data.</param>
        private void userInputPanel_Paint(object sender, PaintEventArgs pegs)
        {
            // Draw a rectangler border around the userInputPanel control
            ControlPaint.DrawBorder(pegs.Graphics, userInputPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            // Get the Graphics object for the userInputPegs
            Graphics userInputPegsGraphics = pegs.Graphics;

            // Initialize x-coordinate for drawing the ellipses
            int xcoords = 241;

            // Loop through each element in the user pegs array
            for (int i = 0; i < secretCode.Length; i++)
            {
                // Determine the brush color based on the user pegs value
                switch (userPegs[i])
                {
                    case 1:
                        outputBrush = redBrush;
                        break;
                    case 2:
                        outputBrush = blueBrush;
                        break;
                    case 3:
                        outputBrush = yellowBrush;
                        break;
                    case 4:
                        outputBrush = greenBrush;
                        break;
                    case 5:
                        outputBrush = purpleBrush;
                        break;
                    case 6:
                        outputBrush = pinkBrush;
                        break;
                    case 7:
                        outputBrush = whiteBrush;
                        break;
                    case 8:
                        outputBrush = blackBrush;
                        break;
                    case 0:
                        outputBrush = grayBrush;
                        break;
                }
                // Fill an ellipse with the current brush color at the current x-coordinate
                userInputPegsGraphics.FillEllipse(outputBrush, xcoords, 75, 35, 35);

                // Reset the brush color to gray
                outputBrush = grayBrush;

                // Displays the next peg 40px to the right.
                xcoords += 40;
            }
        }
        /// <summary>
        /// Handles the Paint event of the mastermindOutputPanel control.
        /// Draws ellipses on the mastermindOutputPanel control to represent the clue pegs and the submitted pegs.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="pegs">The instance containing the event data.</param>
        private void mastermindOutputPanel_Paint(object sender, PaintEventArgs pegs)
        {
            // Draw a border around the mastermindOutputPanel control
            ControlPaint.DrawBorder(pegs.Graphics, mastermindOutputPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            // Draw the clue pegs
            Graphics cluePegGraphics = pegs.Graphics;
            int x = 10;
            int y = 50;
            Pen whitePen = new(Color.White);
            cluePegGraphics.DrawRectangle(whitePen, 5, 40, 50, 565);
            // Draws the amount of columns based on guessNumber.
            for (int l = 0; l < guessRowNumber; l++)
            {
                // Draws the first layer of clue pegs, so if the secretCode
                // If the secret code length is 4 the Clue Pegs will be displayed in a 2 by 2 grid and so on.
                for (int i = 0; i < secretCode.Length / 2; i++)
                {
                    // Determine the brush color based on the radio store element
                    switch (cluePegStore[i, l])
                    {
                        case "Red":
                            cluePegGraphics.FillEllipse(redBrush, x, y, 10, 10);
                            break;
                        case "White":
                            cluePegGraphics.FillEllipse(whiteBrush, x, y, 10, 10);
                            break;
                        default:
                            cluePegGraphics.FillEllipse(grayBrush, x, y, 10, 10);
                            break;
                    }
                    // Moves pegs horizontally to the right.
                    x += 10;
                }
                // Puts space between the clue pegs vertically, whilst reseting the x value.
                y += 10;
                x = 10;
                // Draws the second layer of clue pegs
                for (int i = secretCode.Length / 2; i < secretCode.Length; i++)
                {
                    // Determine the brush color based on the radio store element
                    switch (cluePegStore[i, l])
                    {
                        case "Red":
                            cluePegGraphics.FillEllipse(redBrush, x, y, 10, 10);
                            break;
                        case "White":
                            cluePegGraphics.FillEllipse(whiteBrush, x, y, 10, 10);
                            break;
                        default:
                            cluePegGraphics.FillEllipse(grayBrush, x, y, 10, 10);
                            break;
                    }
                    // Moves each peg 10px to the right.
                    x += 10;
                }
                // Puts space between the clue pegs vertically, whilst reseting the x value.
                x = 10;
                y += 25;
            }
            // Set gamestate to false
            //gamestate = false;

            // Draw the current user inputs and draw the rows and columns for the submited pegs.
            Graphics submitedPegsGraphics = pegs.Graphics;
            y = 45;
            x = 65;
            for (int a = 0; a < guessRowNumber; a++)
            {
                for (int i = 0; i < secretCode.Length; i++)
                {
                    // Determine the brush color based on the submitedPegStore
                    outputBrush = submitedPegsStore[i, a] switch
                    {
                        1 => redBrush,
                        2 => blueBrush,
                        3 => yellowBrush,
                        4 => greenBrush,
                        5 => purpleBrush,
                        6 => pinkBrush,
                        7 => whiteBrush,
                        8 => blackBrush,
                        _ => grayBrush,
                    };

                    // Draw the ellipse on the submitedPegsGraphics object
                    submitedPegsGraphics.FillEllipse(outputBrush, x, y, 32, 32);
                    outputBrush = grayBrush;
                    Invalidate();
                    x += 40;
                }
                x = 65;
                y += 35;
            }
        }
        /// <summary>
        /// Handles the Click event of the color circle buttons.
        /// Adds the selected color to the user's pegs array.
        /// If the number of selected pegs is less than the secret code length, update the user's pegs array and increment the counter.
        /// Refreshes the display.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void colorCircleButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter < secretCode.Length)
            {
                Button colorButton = (Button)sender;
                int colorValue = Convert.ToInt32(colorButton.Tag);

                submitedPegs[userPegsArrayCounter] = colorValue;
                userPegs[userPegsArrayCounter] = colorValue;
                userPegsArrayCounter++;
                Refresh();
            }
        }
        /// <summary>
        /// Handles the Click event of the clearButton.
        /// Resets the user's pegs array and counter to start a new guess.
        /// Refreshes the display.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter == 0)
            {
                // Display a message box informing the user that there are no pegs to clear
                MessageBox.Show("There are no pegs to clear.", "Empty Guess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Remove one peg from the end of the array
                userPegsArrayCounter--;
                userPegs[userPegsArrayCounter] = 0;
                Refresh();
            }
        }
        /// <summary>
        /// Handles the Click event of the clearButton.
        /// Resets the user's pegs array and counter to start a new guess.
        /// Refreshes the display.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter == 0)
            {
                // Display a message box informing the user that there is nothing to clear
                MessageBox.Show("There are no guesses to clear.", "Empty Guess Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Clear the user's guesses
                userPegsArrayCounter = 0;
                for (int i = 0; i < secretCode.Length; i++)
                {
                    userPegs[i] = 0;
                }
                Refresh();
            }
        }
        /// <summary>
        /// When there are the same number of user selected pegs and secret code length. 
        /// Set the gamestate to true, and call the countdown and checkPegs methods.
        /// Then reset the user colour array to gray, so the user can have multiple guesses.
        /// Else display an messagebox, if they do not fill the colorButtonArray.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (userPegsArrayCounter == secretCode.Length)
            {
                userPegsArrayCounter = 0;
                //gamestate = true;
                CheckPegs();
                CountDown();
                Refresh();
            }
            else
            {
                string title = "Submit Button Error";
                string message = "Please fill the entire row before submitting your guess";

                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Sets userPegs to Gray everytime it is called.
        /// Compares the submitedPegs to the secretCode to find the red, white and gray pegs.
        /// Shuffles the position of red, white and gray pegs, before they are displayed.
        /// This avoids the user being able to figure out what clue peg is assigned to a submited peg.
        /// Then sends a signal so the red, white and gray pegs can be displayed by other memories.
        /// If the number of redhits == secretCode.Length call the Win method
        /// Else add 1 to the counter, so that the clue pegs are displayed in the correct positi
        /// </summary>
        private void CheckPegs()
        {
            // Initialize boolean arrays to track which elements in the secret code have been matched
            bool[] redVisited = new bool[codeLength];
            bool[] whiteVisited = new bool[codeLength];

            // Initialize counters for red and white pegs
            int redHits = 0;
            int whiteHits = 0;

            

            // Loop through to display the empty gray pegs for the submitted pegs
            for (int i = 0; i < secretCode.Length; i++)
            {
                // Assign value of submitted peg to corresponding element in user pegs array
                userPegs[i] = 0;

                // Store 0 in graphic store array, so when it is displayed the colour is Gray.
                submitedPegsStore[i, guessRowPositionTracker] = submitedPegs[i];


            }

            // Find the gray pegs (incorrect color and incorrect index)
            for (int i = 0; i < secretCode.Length; i++)
            {
                if (submitedPegs[i] != secretCode[i])
                {

                    cluePegCommands[i] = "Gray";
                }
            }

            // Find red pegs (correct color and correct index)
            for (int i = 0; i < secretCode.Length; i++)
            {

                if (submitedPegs[i] == secretCode[i])
                {
                    // Increment red peg counter and mark element as visited in red visited array
                    redHits++;
                    redVisited[i] = true;
                    cluePegCommands[i] = "Red";
                    continue;
                }
            }
            // Find white pegs (correct color, incorrect index).
            for (int i = 0; i < secretCode.Length; i++)
            {
                // Skip any elements that have already been counted as red pegs, to avoid duplicates.
                if (redVisited[i])
                {
                    continue;
                }

                // Nested loop to find matching elements in the secret code array
                for (int j = 0; j < secretCode.Length; j++)
                {
                    // Skip this iteration if the indices are the same
                    if (j == i)
                    {
                        continue;
                    }

                    // If the secret code peg has not been marked as visited in either the red or white visited arrays
                    // As well as matching the submited Peg.
                    if (!redVisited[j] && !whiteVisited[j] && secretCode[j] == submitedPegs[i])
                    {
                        whiteHits++;
                        whiteVisited[j] = true;
                        cluePegCommands[i] = "White";
                        break;
                    }
                }
            }
            // Shuffle the red and white pegs, so that the user cannot infer what position the submited pegs correspond to.
            var shuffledCluePegs = cluePegCommands.OrderBy(a => Guid.NewGuid()).ToList();

            // Store the red and white pegs in the i variable.
            for (int i = 0; i < secretCode.Length; i++)
            {
                cluePegStore[i, guessRowPositionTracker] = shuffledCluePegs[i];
            }


            if (redHits == secretCode.Length)
            {
                Win();
            }
            //If user has not won, decrement the counter.
            // So there next guess is submitted to the row above previous guess.
            else
            {
                guessRowPositionTracker--;
            }


        }
        /// <summary>
        /// Disables all the buttons, which prevents errors after the game has finished.
        /// </summary>
        public void DisableElements()
        {
            submitButton.Enabled = false;
            clearAllButton.Enabled = false;
            redCircleButton.Enabled = false;
            blueCircleButton.Enabled = false;
            yellowCircleButton.Enabled = false;
            greenCircleButton.Enabled = false;
            pinkCircleButton.Enabled = false;
            purpleCircleButton.Enabled = false;
            whiteCircleButton.Enabled = false;
            blackCircleButton.Enabled = false;
            helpButton.Enabled = false;
            quitButton.Enabled = false;
            clearButton.Enabled = false;
        }
        /// <summary>
        /// Every it is called subtrat 1 from attemptsLeft.
        /// Once the user runs out of attempts call the Lose method. 
        /// </summary>
        private async void CountDown()
        {
            attemptsLeft--;
            // Makes sure that winstate is false.
            // To prevent displaying the lose screen if the user guessed correctly on their last attempt.
            if (attemptsLeft == 0 && !winstate)
            {
                Lose();
            }
        }
        /// <summary>
        /// sets Winstate to true, and shows the WinScreen.
        /// </summary>
        private async void Win()
        {
            winstate = true;
            DisableElements();
            await Task.Delay(3000);
            WinScreen winScreen = new();
            winScreen.Show();
            Hide();
            // Resets the winstate, so the user can play mastermind,
            // without having to restart the program.
            winstate = false;
        }
        /// <summary>
        /// Sets the winstate to false, then displays the LoseScreen.
        /// </summary>
        private async void Lose()
        {
            winstate = false;
            DisableElements();
            await Task.Delay(3000);
            LoseScreen loseScreen = new();
            loseScreen.Show();
            Hide();
        }
        /// <summary>
        /// Allows the user to quit the program.
        /// </summary
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Displays the help menu on the helpButton click.
        /// </summary>
        private void helpButton_Click(object sender, EventArgs e)
        {
            InheritedHelpMenu inheritedHelpMenu = new();
            inheritedHelpMenu.Show();
        }


    }
}