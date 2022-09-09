//Extra utmaning 2: skriv ett sten-sax-påse spel.
//Användaren skriver in “sten”, “sax” eller “påse”. Dators val slumpas med Random.
//Skriv sedan ut vad datorn valde, och vem som vann omgången.
//Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något).
//Skriv även ut poäng.

Random rnd = new Random();
var player = "";
var opponent = "";
var playerPointe = 0;
var opponentPointe = 0;


while (true)
{
    while (true)
    {
        Console.WriteLine("Sten, sax, påse!");
        player = Console.ReadLine();
        if (player == "") { break; }
        else if (player == "sten" || player == "sax" || player == "påse") { break; }
        
    } 

    if (player == "") { break; }


    int opponentInt = rnd.Next(1, 4);

    switch (opponentInt)
    {
        case 1:
            opponent = "sten";
            break;
        case 2:
            opponent = "sax";
            break;
        case 3:
            opponent = "påse";
            break;
    }

    if (opponent == player) 
    {
        Console.WriteLine($"Du valde {player}, din motståndare valde {opponent}. Det blev lika! Ingen poäng");
    }

    else if (player == "sten" && opponent == "sax" || player == "sax" && opponent == "påse" || player == "påse" && opponent == "sten")
    {
        Console.WriteLine($"Du valde {player}, din motståndare valde {opponent}. Du vann! 1 poäng till dig!");
        playerPointe++;
    }

    else
    {
        Console.WriteLine($"Du valde {player}, din motståndare valde {opponent}. Du förlorade! 1 poäng till din motståndare!");
        opponentPointe++;
    }
}

Console.WriteLine($"Tack för att du spelade!\nDu fick: {playerPointe} poäng\nDin motståndare fick: {opponentPointe} poäng.");