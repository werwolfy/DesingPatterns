namespace State.PlayerStates;

public class Walking : IPlayerState
{
    public Walking(Player player)
    {
        _player = player;
    }
    public Player _player { get; set; }

    public void Shoot()
    {
        Console.WriteLine("Fires a precise shoot");
    }

    public void Jump()
    {
        Console.WriteLine("Jumps high but not far");
        _player.State= new Jumping(_player);
    }

    public void Run()
    {
        Console.WriteLine("Starts running");
        _player.State = new Running(_player);
    }

    public void Walk()
    {
        Console.WriteLine("Keeps walking");
    }
}