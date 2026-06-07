using Composite;

Box big = new Box();
big.Add(new Product(17.0));

Box inner = new Box();
inner.Add(new Product(5.0));
inner.Add(new Product(2.5));
big.Add(inner);

// Client code treats leaf and composite identically:
IComponent root = big;
Console.WriteLine(root.GetPrice());