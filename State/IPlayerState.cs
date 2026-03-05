namespace State;

public interface IPlayerState
{
    public void Shoot();
    public void Jump();
    public void Run();
    public void Walk();
}