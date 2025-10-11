namespace Observer.Subscriber;


// Das sind die Concrete Subscriber

public class GlobalNewspaper : ISubscriber
{
    public string Title { get; set; }
    public void UpdateTitlePage(string title)
    {
        Title = title;
    }
}