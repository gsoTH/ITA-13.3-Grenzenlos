namespace Grenzenlos;

public class Sitzplatz
{
    private int reihe;
    private string platz;

    public Sitzplatz(int reihe, string platz)
    {
        this.reihe = reihe;
        this.platz = platz;
    }
    
    public int Reihe { get { return reihe; } }
    public string Platz { get { return platz; } }
    public string Nummer { get{ return reihe.ToString() + platz; } }
    public bool IstVIP { get { return reihe <= 25; } }
    public bool IstNotausgang { get { return reihe == 50; } }
}