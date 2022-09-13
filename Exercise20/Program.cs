// Använd DrawBox-metoden i föregående uppgift för att rita en box.
// Placera sedan ett @ i mitten av boxen.
// Om man använder piltangenterna ska man kunna flytta runt @.
// När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.
// Hint: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
// Spara bredd och höjd på boxen så du vet när den ska stanna.


Console.WriteLine("Hello, World!");


void DrawBox(int width, int height)
{
	Console.Clear();

	for (int i = 0; i < height; i++)
	{
		if (i == 0 || i + 1 == height)
		{
			for (int j = 0; j < width; j++)
			{
				Console.Write("#");
			}
			Console.Write("\n");
		}

		else
		{
			Console.Write("#");
			for (int j = 0; j < width - 2; j++)
			{
				Console.Write("-");
			}
			Console.Write("#\n");
		}
	}
}