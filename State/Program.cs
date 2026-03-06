using State;
using State.PlayerStates;

Player playerOne = new Player();
playerOne.State = new Walking(playerOne);
playerOne.State.Shoot();
playerOne.Run();
playerOne.Run();
playerOne.Shoot();
playerOne.Jump();
playerOne.Jump();
playerOne.Walk();
playerOne.Jump();
playerOne.Run();
playerOne.Jump();