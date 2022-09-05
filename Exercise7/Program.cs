//Skriv ett program som ber användaren skriva in en månad. Programmet ska göra om månaden till månadens siffervärde.
//T.ex. ska januari bli 1 och december 12. Använd switch.
//Alternativ: Prova även att lösa uppgiften med array och/eller enum.
//xtra utmaning: Be användaren om två månader och räkna sedan ut hur många månader som skiljer mellan dem.
//Tänk på att ett månaderna upprepas till nästa år. Skriver man mars och maj bör man få 2.
//Likaså om man skriver november och januari.

string maanad1, maanad2;
int mValue1 = 0, mValue2 = 0, mDiff = 0;

string[] maanader = new string[] { "januari", "februari", "mars", "april", "maj", "juni", 
    "juli", "augusti", "september", "oktober", "november", "december" };

while (true)
{
    Console.WriteLine("Skriv in en månad (endast små bokstäver):");

    maanad1 = Console.ReadLine();

    if (maanad1 == Array.Find(maanader, element => element == maanad1))
    { 
        mValue1 = MonthValueFinder(maanad1, maanader);
        break;
    }

    Console.WriteLine("Det var inte rätt! Använde du små bokstäver?");
}

while (true)
{
    Console.WriteLine("Skriv in en annan månad (endast små bokstäver):");

    maanad2 = Console.ReadLine();

    if (maanad1 == maanad2)
    {
        Console.WriteLine("Olika månader, sa jag!");
    }

    else if (maanad2 == Array.Find(maanader, element => element == maanad2))
    {
        mValue2 = MonthValueFinder(maanad2, maanader);
        break;
    }

    Console.WriteLine("Det var inte rätt! Använde du små bokstäver?");
}

if (mValue1 > mValue2)
{
    mValue1 -= 12;
}


 mDiff = mValue1 - mValue2;

if (mDiff < 0)
{
    mDiff = Math.Abs(mDiff);
}

if (mDiff == 1)
{
    Console.WriteLine($"Det är {mDiff} månad mellan {maanad1} och {maanad2}");
}

else { Console.WriteLine($"Det är {mDiff} månader mellan {maanad1} och {maanad2}"); }


static int MonthValueFinder( string maanad, string[] maanader ) 
{
    for (int i = 0; i < maanader.Length; i++)
    {
        if (maanader[i] == maanad)
        {
            return i++;
        }
    }
    return 0;
}