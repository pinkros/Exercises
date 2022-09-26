
using System.Security.Cryptography;

namespace Exercise29;

public class Car
{
    Random rnd = new Random();
   
    private ColorSelection _color;
    private double _length;

    public double Length
    {
        get { return _length; }
        set
        {
            double centimeters = rnd.Next(300, 501);
            _length = Math.Round(centimeters, 2);
        }
    }

    public ColorSelection Color
    {
        get { return _color; }
        set
        {
            int colorRandom = rnd.Next(0, 5);
            _color = (ColorSelection)colorRandom;
        }
    }
}