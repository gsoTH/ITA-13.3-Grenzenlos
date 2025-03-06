using Grenzenlos;
namespace GrenzenlosTests;

[TestClass]
public class PersonTests
{
    [TestMethod]
    public void Person_erstellbar()
    {
        // Arrange
        string name = "Max Mustermann";

        // Act
        Person p = new Person(name);

        // Assert
        Assert.AreEqual(name, p.Name);
        Assert.IsFalse(p.IstVIP);
        Assert.IsFalse(p.IstKind);
    }
    
    [TestMethod]
    public void Person_erstellbarVIP()
    {
        // Arrange
        string name = "Max Mustermann";
        bool istVIP = true;

        // Act
        Person p = new Person(name, istVIP);

        // Assert
        Assert.AreEqual(name, p.Name);
        Assert.IsTrue(p.IstVIP);
        Assert.IsFalse(p.IstKind);
    }
    
    [TestMethod]
    public void Person_erstellbarKind()
    {
        // Arrange
        string name = "Max Mustermann";
        bool istVIP = true;
        bool istKind = true;

        // Act
        Person p = new Person(name, istVIP, istKind);

        // Assert
        Assert.AreEqual(name, p.Name);
        Assert.IsTrue(p.IstVIP);
        Assert.IsTrue(p.IstKind);
    }
}

/*Jede Buchung besteht aus Abflugzeit, Sitzplatz und einer Person.

    Durch das Nachtflugverbot darf die Abflugzeit einer Buchung nur zwischen 6 und 22 Uhr liegen.
    Alle unsere Flugzeuge haben eine gleiche Anzahl an Sitzplätzen, die sich Reihen mit den Nummern 1 bis 100 Reihen mit je 6 Plätzen (A bis F) verteilen. Jeder Sitzplatz hat eine zugehörige Nummer für die Reihe und einem Buchstaben für den Platz. Der Sitzplatz 86C liegt beispielsweise in der 86. Reihe, direkt am Gang. Die Sitzplätze 1A und 1F wären in der ersten Reihe jeweils am Fenster. Die Reihen 1-25 sind sogenannte VIP-Plätze. Die Notausgänge befinden sich in Reihe 50.
    Jede Person kann ein Kind und/oder VIP oder keins von beidem sein. VIPs dürfen nicht auf normalen Sitzplätzen buchen und umgekehrt. Kinder dürfen nicht in den Reihen des Notausgangs am Fenster sitzen.
*/