namespace Exercise27;

public class ColoredObject
{
    private float _red;
    private float _blue;

    public float Red
    {
        get { return _red; }
        set
        {
            if (0 <= value && value <= 100)
            {
                _red = value;
                _blue = 100 - value;
            }

            else
            {
                throw new Exception();
            }
        }
    }

    public float Blue
    {
        get { return _blue; }
        set
        {
            if (0 <= value && value <= 100)
            {
                _blue = value;
                _red = 100 - value;
            }

            else
            {
                throw new Exception();
            }
        }
    }
}