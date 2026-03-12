using State;
using State.PlayerStates;

Player playerOne = new Player();
playerOne.State = new Walking(playerOne);
playerOne.Run(); // Starts running
playerOne.Walk(); // Slows down to walking speed
playerOne.Run(); // Starts running
playerOne.Run(); // Keeps running
