int loopVar = 0;
var times = 0;

Console.WriteLine("Hej! Vad heter du?");
string name = Console.ReadLine();

Console.WriteLine("Hur många hälsningar vill du ha?");

while (loopVar == 0)
{
    try
    {
        times = Int32.Parse(Console.ReadLine());
        loopVar++;
    }
    catch
    {
        Console.WriteLine("det var inte vad jag bad om, försök igen!");
        loopVar = 0;
    }
}
for (int i = 0; i < times; i++)
{
    Console.WriteLine($"Hej, {name}!");
}

