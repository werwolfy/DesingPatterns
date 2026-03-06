using State.PlayerStates;

namespace State;

public class Player
{
    public Player()
    {
        State = new Walking(this);
    }
    public IPlayerState State { get; set; }
    public void Run() => State.Run();
    public void Walk() => State.Walk();
    public void Jump() => State.Jump();
    public void Shoot() => State.Shoot();

}