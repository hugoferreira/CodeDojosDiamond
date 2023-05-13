namespace Diamond.Tests;

[TestFixture]
public class DiamondMakerUnitTests {
  [Test]
  public void TestDiamondA() {
    string result = DiamondMaker.GenerateDiamond('A');
    Assert.That(result, Is.EqualTo("A"));
  }

  [Test]
  public void TestDiamondB() {
    string result = DiamondMaker.GenerateDiamond('B');
    Assert.That(result, Is.EqualTo(" A\nB B\n A"));
  }

  [Test]
  public void TestDiamondC() {
    string result = DiamondMaker.GenerateDiamond('C');
    Assert.That(result, Is.EqualTo("  A\n B B\nC   C\n B B\n  A"));
  }

  [Test]
  public void TestDiamondD() {
    string expected = "   A\n  B B\n C   C\nD     D\n C   C\n  B B\n   A";
    string result = DiamondMaker.GenerateDiamond('D');
    Assert.That(result, Is.EqualTo(expected));
  }

  [Test]
  public void TestInvalidCharacterThrowsException() {
    var invalidCharacters = Enumerable.Range(0, 255)
      .Select(i => (char) i)
      .Where(c => !DiamondMaker.alphabet.Contains(c));
      
    foreach (var invalidChar in invalidCharacters) {
      Assert.Throws<ArgumentException>(() => DiamondMaker.GenerateDiamond(invalidChar));
    }
  }
}