//Client

using Builder;

CarBuilder b = new CarBuilder();
Director d = new Director();
Car c = new Car();
Console.WriteLine("wir haben c ps: " + c.Ps);
Car c1 = b.SetPs(300).SetAmountOfDoors(6).HasHeckspoiler(true).SetColor("Green").Build();
Console.WriteLine("wir haben c1 ps: " + c1.Ps);
Car c2 = b.Build();
Console.WriteLine("wir haben c2 ps: " + c2.Ps);
Car Floppi = b
    .SetAmountOfDoors(2)
    .SetColor("Blau")
    .HasHeckspoiler(true)
    .SetPs(67)
    .Build();
Car c3 = new Car(){ AmauntOfDoors = 2, Color =  "Blue" ,Ps = 67, HasHeckspoiler =  true };