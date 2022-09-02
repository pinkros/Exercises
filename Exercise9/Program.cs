// Skriv ett program som frågar användaren efter ett tal mellan 1 och 100.
// Programmet ska ha ett hemligt tal lagrat i en variabel.
// Det ska fortsätta fråga användaren till dess att användaren gissar det hemliga talet.
// Om man gissade för högt eller för lågt så ska det skrivas ut, så att användaren har en rimlig chans att klara det.
// Exempel: programmet har det hemliga talet 27. Användaren gissar på 50.
// Programmet skriver ut att användaren gissade för högt.
// Användaren gissar på 20. Programmet skriver ut att det var för lågt. Användaren gissar på 27.
// Programmet skriver ut att det var rätt och avslutas.
Random rnd = new Random();

var secretNum = rnd.Next(1, 100);
var guessNum = 0;

while (true)
{
    Console.WriteLine("Gissa ett tal mellan 1 och 100!");


    while (true)
    {
        string input = Console.ReadLine();

        if (int.TryParse(input, out guessNum))
        {
            if (guessNum < 100 || guessNum > 0)
            {
                break;

            }
        }
        Console.WriteLine("Det var inte vad jag bad om!");

    }

    while (guessNum != secretNum)
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out guessNum))
            {
                if (guessNum < 100 || guessNum > 0)
                {
                    break;

                }
            }
            Console.WriteLine("Det var inte vad jag bad om!");
        }

        if (guessNum < secretNum)
        {
            Console.WriteLine("För lågt!\nProva igen!");
        }
        else
        {
            Console.WriteLine("För högt!\nProva igen!");
        }
    }
    break;
}
Console.WriteLine($"Du gissade {guessNum} och talet var {secretNum}. Grattis!");