namespace Exercise28;

public class Person
{

    private string _firstName;
    private string _lastName;

    public string Name
    {
        get { return $"{_firstName} {_lastName}"; }
        set
        {
            string[] names = value.Split(' ');
            _firstName = names[0];
            _lastName = names[1];
        }
    }
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
}