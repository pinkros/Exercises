// Fråga användaren hur många tal den vill mata in.
// Fråga sedan efter talen i tur och ordning (“Ange tal 1:” osv).
// När alla tal är inmatade skriv ut dem i omvänd ordning.

var arrLength = 0;

while (true)
{
    // Be användaren skriva in ett tal.
    Console.WriteLine("Hur många tal vill du mata in?");

    string input = Console.ReadLine();

    //      Spara talet i en int.
    if (int.TryParse(input, out arrLength))
    {
        break;
    }

    Console.WriteLine("vänligen mata in ett antal, inget annat");
}

int[] talserie = new int[arrLength];

// Be användaren skriva in så många nummer som talet anger.
for (int i = 0; i < talserie.Length; i++)
{
    while (true)
    {
        Console.WriteLine($"skriv in tal {i + 1}:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int result))
        {
            //      Spara numren i en array så stor som talet.
            talserie[i] = result;
            break;
        }

        else
        {
            Console.WriteLine("nope, prova igen");
        }
    }
}

// Skriv ut numren i LIFO-ordning.
Array.Reverse(talserie);

foreach (var nmbr in talserie)
{
    Console.Write($"{nmbr} ");
}