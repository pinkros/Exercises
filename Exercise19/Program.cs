// Skriv en metod DrawBox(int width, int height)
// När man anropar metoden ska den tömma konsolen och skriva ut en rektangel där de yttre tecknen består av ‘#’ och de inre av ‘-’

DrawBox(7, 7);

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