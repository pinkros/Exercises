// Skriv en klass som representerar en bil.
// Varje bil ska kunna ha en färg som representeras av en enum
// (det ska finna minst 5 olika färger på bilar), samt en längd.
// När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
// Instansiera 1000 bilar och spara i en array.
// Skriv sedan ut den sammanlagda längden av alla gröna bilar.

using Exercise29;

Car[] cars = new Car[1000];
var greenCarsTotalLength = 0.0;
var carsTotalLength = 0.0;

for (int i = 0; i < 1000; i++)
{
    cars[i] = new Car(){Color = 0, Length = 0};
}

foreach (Car car in cars)
{
    if (car.Color == ColorSelection.Green)
    {
        greenCarsTotalLength += car.Length;
    }

    carsTotalLength += car.Length;

}

Console.WriteLine($"De gröna bilarnas totala längd är: {greenCarsTotalLength} \n" +
                  $"Den totala längden av bilarna är: {carsTotalLength}");


