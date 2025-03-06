using Grenzenlos;
namespace GrenzenlosTests;

[TestClass]
public class SitzplatzTests
{
    [TestMethod]
    public void Sitzplatz_erstellbar()
    {
        // Arrange
        int reihe = 1;
        string platz = "A";

        // Act
        Sitzplatz s = new Sitzplatz(reihe, platz);

        // Assert
        Assert.AreEqual(reihe, s.Reihe);
        Assert.AreEqual(platz, s.Platz);
        Assert.AreEqual("1A", s.Nummer);
        Assert.IsTrue(s.IstVIP);
        Assert.IsFalse(s.IstNotausgang);
    }
}