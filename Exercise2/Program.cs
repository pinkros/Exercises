string pw = "12345";
string pwGuess = " ";
Console.WriteLine("Vad är lösenordet?");

pwGuess = Console.ReadLine();

if (pw == pwGuess)
{
    Console.WriteLine("Rätt! Najs!");
}

else
{
    Console.WriteLine("Det var fel.");
}

