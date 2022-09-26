namespace Exercise30;

public class Player
{
    private int _wins;
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Wins
    {
        get { return _wins; }
        set { _wins = value; }
    }

    public Player(string name)
    {
        Wins = 0;
        Name = name;
    }
    public Choice GameState()
    {
        Random random = new Random();

        Choice choice = (Choice)random.Next(0,3);
        return choice;
    }
}