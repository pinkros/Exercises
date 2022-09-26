// See https://aka.ms/new-console-template for more information

using Exercise27;

ColoredObject car = new ColoredObject();

car.Red = 21.5F;

Console.WriteLine($"Röd: {car.Red}\nBlå: {car.Blue}");

car.Blue = 65F;

Console.WriteLine($"Röd: {car.Red}\nBlå: {car.Blue}");

