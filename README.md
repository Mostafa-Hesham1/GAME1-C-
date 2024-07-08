# Project Title

Feff1: A Simple Windows Forms Fighting Game

## Description

This project implements a simple fighting game using Windows Forms in C#. The game involves two players, player 1 and player 2, who can perform various actions such as moving, crouching, boxing, and kicking. The game keeps track of player health and supports collision detection for hits.

## Classes and Their Responsibilities

### Cheath Class
- Represents the health of the players.
- Attributes:
  - `int X, Y`: Coordinates of the health indicator.
  - `Bitmap imgs`: Image representing the health.
  - `int dx`: Direction of movement.
  - `int iCurrFrame`: Current frame of the animation.

### Cfire Class
- Represents the fire actions in the game.
- Attributes:
  - `Rectangle rcDst`: Destination rectangle for drawing the fire.
  - `Rectangle rcSrc`: Source rectangle for drawing the fire.
  - `List<Bitmap> imgs`: List of images representing the fire.
  - `int dx`: Direction of movement.
  - `int iCurrFrame`: Current frame of the animation.

### CActor Class
- Represents the characters in the game.
- Attributes:
  - `Rectangle rcDst`: Destination rectangle for drawing the character.
  - `Rectangle rcSrc`: Source rectangle for drawing the character.
  - `List<Bitmap> imgs`: List of images representing the character.
  - `int iCurrFrame`: Current frame of the animation.
  - `int HEALTH`: Health of the character.

### Form1 Class
- The main form of the game, responsible for handling game logic and user input.
- Attributes:
  - Various integers to keep track of game states and counters.
  - Bitmap objects for storing images used in the game.
  - Random objects for generating random values.
  - Timer object for updating the game state periodically.
  - Lists of `CActor`, `Cfire`, and `Cheath` objects representing the players, fire actions, and health indicators.
- Methods:
  - `Form1()`: Constructor, sets up the form and event handlers.
  - `Tt_Tick()`: Handles timer ticks to update game state.
  - `hit()`, `hit2()`, `hit3()`: Handle different hit actions.
  - `moveenm()`: Moves the enemy character.
  - `Form1_KeyDown()`: Handles key press events for player actions.
  - `CreateParamsfighttext()`: Creates initial fight text display.
  - `endd()`, `player1win()`, `player1lose()`, `player2losee()`, `player2win()`: Handle end game states and display results.
  - `Form1_Paint()`: Handles the paint event to draw the game.
  - `DrawDubb()`, `DrawScene()`: Handle double buffering and scene drawing.

## Key Bindings

- `D`: Move player 1 to the right.
- `A`: Move player 1 to the left.
- `S`: Crouch.
- `E`: Boxing action.
- `R`: Kick action.
- `F`: Special finish action.
- `Q`: Fire action.

## Game Flow

1. The game starts with both players at their initial positions.
2. Player 1 can move, crouch, box, kick, and perform special actions using the key bindings.
3. Player 2's actions are controlled by the game logic and random events.
4. The game updates the state periodically using a timer.
5. The game detects collisions and updates health accordingly.
6. The game ends when one player's health reaches zero, displaying the winner or loser image.

## How to Run

1. Open the project in Visual Studio.
2. Make sure all images (bitmaps) used in the code are present in the project directory.
3. Build and run the project.
4. Use the key bindings to control player 1 and interact with the game.

## Dependencies

- .NET Framework
- System.Drawing
- System.Windows.Forms
