namespace State.PlayerStates;

public class Jumping : IPlayerState
{
    public Jumping(Player player)
    {
        _player = player;
    }
    public Player _player { get; set; }

    public void Shoot()
    {
        Console.WriteLine("Fires a random shoot");
    }

    public void Jump()
    {
        Console.WriteLine("cant jump while in air");
    }

    public void Run()
    {
        Console.WriteLine("Lands and starts running");
        _player.State = new Running(_player);
    }

    public void Walk()
    {
        Console.WriteLine("Lands and starts walking away");
        _player.State = new Walking(_player);
    }
}