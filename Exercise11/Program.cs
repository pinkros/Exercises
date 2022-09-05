//Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”,
//“åtta”, “nio”. Be sedan användaren att mata in en siffra.
//Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.
//Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror, om man skriver in t.ex 432 så svarar programmet: “fyra - tre - två”.

string[] numbers = new string[10] {"noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"};
int nmbr;
string input, output = "";
while (true)
{
    Console.WriteLine("skriv ett tal:");
    input = Console.ReadLine();
    if (int.TryParse(input, out nmbr)) { break; }
    else 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ett TAL, sa jag");
        Console.ResetColor();
    }
}

if (input.Length == 1)
{
    output = numbers[nmbr];
}

else 
{
    
    for (int i = 0; i < input.Length; i++)
    {
        //varför funkar dt inte??? :'(
        output += numbers[input[i]];
        output += "-";
    }
}


Console.WriteLine(output);