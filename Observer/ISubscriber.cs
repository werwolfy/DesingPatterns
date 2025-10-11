namespace Observer;

// Das ist das Interface

public interface ISubscriber
{
    public string Title {get; set;}
    public void UpdateTitlePage(string title);
}