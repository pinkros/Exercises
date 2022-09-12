// Be användaren mata in en mening.
// Skriv ut det genomsnittliga antalet bokstäver i orden.

char[] separators = new char[] { ' ', '.' };
var sum = 0.0;
var amount = 0.0;

Console.WriteLine("Skriv in en mening:");

string sentence = Console.ReadLine();

string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

foreach (var word in words)
{
    sum += word.Length;
    amount++;
}


double mean = sum / amount;

Console.WriteLine($"Den genomsnittsliga längden på orden i meningen är: {Math.Round(mean, 2)}");