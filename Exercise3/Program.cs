int loopVar = 0;
int input = 0;
Console.WriteLine("Skriv ett heltal:");

//While loop för att kunna testa koden flera gånger på samma gå, samma med loopVar i if-satserna. 
//while (input != 666)
//{
    while (loopVar == 0)
    {
        try
        {
            input = Int32.Parse(Console.ReadLine());
            loopVar++;
        }
        catch
        {
            Console.WriteLine("det var inte vad jag bad om, försök igen!");
            loopVar = 0;
        }
    }

    if (input < 100)
    {
        Console.WriteLine("Ditt tal är mindre än 100.");
        //loopVar = 0;
    }
    else if (input > 100)
    {
        Console.WriteLine("Ditt tal är större än hundra.");
        //loopVar = 0;
    }
    else
    {
        Console.WriteLine("Ditt tal är exakt hundra.");
        //loopVar = 0;
    }
//}