namespace Cptis.Core.Tests;

public class PhoneNumberTests
{
    [TestCase("850-555-1234")]
    [TestCase("850555-1234")]
    [TestCase("8505551234")]
    [TestCase("(850)555-1234")]
    [TestCase("(850) 555-1234")]
    [TestCase("(850) 5551234")]
    [TestCase("850.555.1234")]
    public void Can_Parse_PhoneNumber(string phoneString)
    {
        //arrange
        const string area = "850";
        const string number = "5551234";
        
        //act
        var phone = PhoneNumber.FromString(phoneString);
        
        //assert
        Assert.Multiple(() =>
        {
            Assert.That(phone.AreaCode, Is.EqualTo(area));
            Assert.That(phone.Number, Is.EqualTo(number));
        });
    }
    
    [TestCase("850-555-1234 x 9999")]
    [TestCase("850555-1234 x9999")]
    [TestCase("8505551234x9999")]
    [TestCase("(850)555-1234 9999")]
    [TestCase("(850) 555-1234 x9999")]
    [TestCase("(850) 5551234 x9999")]
    [TestCase("850.555.1234 x9999")]
    public void Can_Parse_PhoneNumber_With_Extension(string phoneString)
    {
        //arrange
        const string ext = "9999";
        
        //act
        var phone = PhoneNumber.FromString(phoneString);
        
        //assert
        Assert.That(phone.Extension, Is.EqualTo(ext));
    }
}