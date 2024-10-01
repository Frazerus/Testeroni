
namespace Testeroni.Test;

public class Tests
{ 
  [Test]
  public void IsNumber()
  {
    var result = RegexParser.IsNumber("13a", out var number, out var substring);

    Assert.That(result, Is.True);
    Assert.That(number, Is.EqualTo(13));
    Assert.That(substring, Is.EqualTo("a"));

    result = RegexParser.IsNumber("62334", out number, out substring);

    Assert.That(result, Is.True);
    Assert.That(number, Is.EqualTo(62334));
    Assert.That(substring, Is.EqualTo(""));

    result = RegexParser.IsNumber("kjkd", out number, out substring);

    Assert.That(result, Is.False);
    Assert.That(number, Is.EqualTo(0));
    Assert.That(substring, Is.EqualTo("kjkd"));
  }

  [Test]
  public void IsString()
  {
    var result = RegexParser.IsString('{', "{asdf", out var substring);

    Assert.That(result, Is.True);
    Assert.That(substring, Is.EqualTo("asdf"));
  }
}