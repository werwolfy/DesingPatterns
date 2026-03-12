using Observer;
using Observer.Subscriber;

// Das ist der Client


Newspaper newspaper = new Newspaper();
LocalNewspaper localSubscriber1 = new LocalNewspaper();
LocalNewspaper localSubscriber2 = new LocalNewspaper();
newspaper.AddSubscriber(localSubscriber1);
newspaper.AddSubscriber(localSubscriber2);
newspaper.Notify("Breaking News: Das Wetter ist schlecht!");
Console.WriteLine($"Local 1: {localSubscriber1.Title}");
Console.WriteLine($"Local 2: {localSubscriber2.Title}");
newspaper.RemoveSubscriber(localSubscriber2);
newspaper.Notify("Breaking News: Das Wetter ist super gut!");
Console.WriteLine($"Local 1: {localSubscriber1.Title}");
Console.WriteLine($"Local 2 (abgemeldet): {localSubscriber2.Title}");


