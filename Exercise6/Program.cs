//Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, *eller /.
//Därefter ska ytterligare ett tal efterfrågas. Programmet ska fungera som en simpel miniräknare.
//Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut “3 * 5 = 15”.

var num1 = 0;
var num2 = 0;
var result = 0;
char opera = ' ';


while (true)
{
    Console.WriteLine("Vänligen skriv in det första talet:");

    try
    {
        num1 = int.Parse(Console.ReadLine());
        break;
    }

    catch
    {
        Console.WriteLine("Ett heltal, bitte.");
    }
}

while (true)
{
    Console.WriteLine("Vänligen skriv in den operator du vill använda (+, -, * eller /):");

    try
    {
        opera = char.Parse(Console.ReadLine());

        if (opera != '+' && opera != '-' && opera != '*' && opera != '/')
        {
            throw new Exception();
        }

        break;
    }

    catch
    {
        Console.WriteLine("En operator, bitte.");
    }
}

while (true)
{
    Console.WriteLine("Vänligen skriv in det andra talet:");

    try
    {
        num2 = Int32.Parse(Console.ReadLine());
        break;
    }

    catch
    {
        Console.WriteLine("Ett heltal, bitte.");
    }
}

switch (opera) 
{ 
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        result = num1 / num2;
        break;
}

Console.WriteLine($"Resultatet är: {num1} {opera} {num2} = {result}");
Console.WriteLine("kthxbai");
Console.ReadLine();