# Mastermind GUI C# Game

This is a graphical user interface (GUI) implementation of the classic Mastermind game in C#. The game consists of several menus, including the main menu, win screen, lose screen, help menu, inherited help menu, and difficulty menu.
Main Menu

The main menu allows the player to start the game, access the help menu, or quit the program. The functionality of the main menu is as follows:

* startButton_Click: Button that shows the difficulty menu and hides the main menu.
* helpButton_Click: Button that shows the help menu and hides the main menu.
* quitButton_Click: Quits the program.
    
# Difficulty Menu

The difficulty menu allows the player to select the secret code length and the number of guesses. It validates the selected values and starts the game with the chosen difficulty. The functionality of the difficulty menu is as follows:

* playButton_Click: If the selected guess number and secret code length are valid, it creates a new instance of the board form and shows it. Otherwise, it shows a warning message to the user.
* secretCodeComboBox_SelectedIndexChanged: Sets the value of the codeLength variable based on the selected value in the secretCodeComboBox.
* guessComboBox_SelectedIndexChanged: Sets the number of guesses the player has based on the selected value.
* quitButton_Click: Quits the program.

# Board

The `Board` class is a Windows Form that represents the main board of the game. It contains various controls and handles user interactions. Here are some of the important members:

- `winstate`: A boolean variable that controls whether the user has won the game.
- `codeLength`: An integer variable that stores the length of the secret code.
- `gamestate`: A boolean variable that determines whether the game is currently in progress.
- `userPegsArrayCounter`: An integer variable that keeps track of the current index in the userPegs array.
- `attemptsLeft`: An integer variable that stores the number of attempts the player has left.
- `guessRowNumber`: An integer variable that stores the number of guess rows.
- `guessRowPositionTracker`: An integer variable that is used to keep track of the current index in the submitedPegsStore and cluePegStore arrays.
- `whitePegs`: An array of integers that stores the number of white pegs for each attempt.
- `cluePegCommands`: An array of strings that stores the clue pegs (red, white, or gray) for each attempt.
- `secretCode`: An array of integers that stores the int representation of the secret code.
- `submitedPegsStore`: A two-dimensional array that stores the submitted pegs for each attempt.
- `cluePegStore`: A two-dimensional array that stores the clue pegs for each attempt.
- `submitedPegs`: An array of integers that stores the pegs the player has currently submitted.
- `userPegs`: An array of integers that stores the pegs the player has selected.
- `randomGenerator`: An instance of the `Random` class used to generate random numbers for the secret code.
- `outputBrush`: A `SolidBrush` object used to draw the pegs on the userInputPanel.
- `grayBrush`, `redBrush`, `yellowBrush`, `blueBrush`, `pinkBrush`, `greenBrush`, `purpleBrush`, `blackBrush`, `whiteBrush`: `SolidBrush` objects used to specify different brush colors.

## colorCircleButton_Click()

This event handler method handles the `Click` event of the `colorCircleButton` controls. It allows the player to select a color for their guess by clicking on one of the color circles. The selected color is stored in the `userPegs` array.

## submitButton_Click()

This event handler method handles the `Click` event of the `submitButton` control. It triggers the validation and evaluation of the player's guess. It compares the submitted pegs with the secret code and updates the clue pegs accordingly. It also checks for a win condition and updates the game state.

## DrawCircle()

This method is used to draw colored circles on the `userInputPanel` and `mastermindOutputPanel` controls. It takes the necessary parameters such as the graphics object, coordinates, and brush color to draw the circles.

## ClearUserInput()

This method clears the `userPegs` array and resets the selection of the color circles in the `userInputPanel` control.

## ResetGame()

This method resets the game state, clears the submitted pegs and clue pegs arrays, and generates a new secret code for a new game.

## Conclusion

The `Board` class in the Mastermind C# GUI game is responsible for managing the game logic and user interactions. It handles the generation of the secret code, drawing the game elements on the board panels, processing user input, evaluating guesses, and updating the game state. By understanding the functionality of the `Board` class, you can gain a deeper understanding of how the game operates and make modifications or improvements as needed.

# Win Screen

The win screen is displayed when the player successfully guesses the secret code. It provides options to play again or quit the game. The functionality of the win screen is as follows:

* playAgainButton_Click: Creates a new instance of the main menu, which is shown, and hides the win screen.
* quitButton_Click: Quits the program.

# Lose Screen

The lose screen is displayed when the player exhausts all the guesses without guessing the secret code. It provides options to play again or quit the game. The functionality of the lose screen is as follows:

* playAgainButton_Click: Creates a new instance of the main menu, which is shown, and hides the lose screen.
* quitButton_Click: Quits the program.

# Help Menu

The help menu provides information and instructions about the game. It allows the player to navigate back to the main menu. The functionality of the help menu is as follows:

* backButton_Click: Calls the Back method, which creates a new instance of the main menu, shows it, and hides the help menu.
* Back: Creates a new instance of the main menu, shows it, and hides the help menu.

# Inherited Help Menu

The inherited help menu extends the functionality of the help menu. It overrides the Back method to only hide the inherited help menu, keeping the current state of the board form. The functionality of the inherited help menu is as follows:

* backMainMenuButtonClick: Calls the overridden Back method.
* Back: Hides the inherited help menu.

# CircleButtons

The `CircleButtons` class is a custom control that inherits all the functionality of a regular button in C#, but with the added ability to display circular buttons. This allows the main board of the Mastermind game to have circular buttons with the same functionality as regular buttons.

## Functionality

The `CircleButtons` class overrides the default `OnPaint` method of the base `Button` class. By doing so, it enables the user to change the color, size, and position of the button, just like a regular button. However, the button's shape is modified to be an ellipse, giving it a circular appearance.

The `OnPaint` method utilizes the `GraphicsPath` class to create a circular path based on the `ClientSize` of the button. It then sets the button's `Region` property to this circular path, ensuring that the button is displayed as a circle. Finally, the base `OnPaint` method is called to perform any additional painting required by the base `Button` class.

Overall this allows for dragging and dropping circular buttons onto the Windows Form Applications. 

# Conclusion

The Mastermind GUI C# Game project provides a graphical user interface implementation of the classic Mastermind game. With various menus, including the main menu, win screen, lose screen, help menu, inherited help menu, and difficulty menu, the game offers an engaging and interactive gameplay experience.
