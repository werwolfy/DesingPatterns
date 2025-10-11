namespace Observer;

// Das ist der Publisher 

public class Newspaper
{
    public List<ISubscriber> Subscribers { get; set; } = new();

    public void AddSubscriber(ISubscriber subscriber)
    {
        Subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(ISubscriber subscriber)
    {
        Subscribers.Remove(subscriber);
    }

    public void Notify(string title)
    {
        foreach (ISubscriber subscriber in Subscribers)
        {
            subscriber.UpdateTitlePage(title);
        }
    }
}