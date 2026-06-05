using Factory;

Creator creator = new Creator();


Building CasionAustria = creator.GetCasino();
Building Hofbrau = creator.GetRestaurante();
Building Hotelx = creator.GetHotel(); 


Console.WriteLine(Hotelx.AmaountOfFloors);