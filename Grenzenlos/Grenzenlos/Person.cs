namespace Grenzenlos;

public class Person
{
    private string name;
    private bool istVIP = false;
    private bool istKind = false;

    public Person(string name)
    {
        this.name = name;
    }
    
    public Person(string name, bool istVIP):this(name)
    {
        this.istVIP = istVIP;
    }
    
    public Person(string name, bool istVIP, bool istKind):this(name, istVIP)
    {
        this.istKind = istKind;
    }
    
    public string Name { get { return name; } }
    public bool IstVIP { get { return istVIP; } }
    public bool IstKind { get { return istKind; } }
}