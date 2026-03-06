namespace State.PlayerStates;

public class Running : IPlayerState
{
    public Running(Player player)
    {
        _player = player;
    }
    public Player _player { get; set; }

    public void Shoot()
    {
        Console.WriteLine("Stops running to be able to shoot");
        _player.State = new Walking(_player);
    }

    public void Jump()
    {
        Console.WriteLine("Jumps far and high");
        _player.State= new Jumping(_player);
    }

    public void Run()
    {
        Console.WriteLine("Keeps running");
        
    }

    public void Walk()
    {
        Console.WriteLine("Slows down to walking speed");
        _player.State = new Walking(_player);
    }
}