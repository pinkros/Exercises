// Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter).
// Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas.
// Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen. Hint: TryParse()

long sum = 0;
int input;
double numOfNums = 0;


while (true)
{
    Console.WriteLine("Skriv in ett tal:");

    try
    {
        input = Int32.Parse(Console.ReadLine());
    }

    catch 
    {
        break;
    }

    sum += input;
    numOfNums++;
}

Console.WriteLine($"Summan av talen är: \n{sum}\nmedeltalet är:\n{sum/numOfNums}");