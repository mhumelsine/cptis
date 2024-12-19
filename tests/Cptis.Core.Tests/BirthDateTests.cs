namespace Cptis.Core.Tests;

public class BirthDateTests
{
    [TestCase("1980-01-01", false)]
    [TestCase("1950-01-01", false)]
    [TestCase("1980-01-01", true)]
    [TestCase("1950-01-01", true)]
    public void Can_Construct_BirthDate(string stringBirthDate, bool isVerified)
    {
        //arrange
        var date = DateTime.Parse(stringBirthDate);
        
        //act
        var birthDate = new BirthDate(date, isVerified);
        
        //assert
        Assert.Multiple(() =>
        {
            Assert.That(birthDate.Date, Is.EqualTo(date));
            Assert.That(birthDate.Verified, Is.EqualTo(isVerified));
        });
    }
    
    [TestCase("1880-01-01", false)]
    [TestCase("1850-01-01", false)]
    [TestCase("2080-01-01", true)]
    [TestCase("2050-01-01", true)]
    public void Can_Fail_Construct_BirthDate(string stringBirthDate, bool isVerified)
    {
        //arrange
        var date = DateTime.Parse(stringBirthDate);
        
        //act
        //assert
        Assert.Throws<ArgumentException>(() => new BirthDate(date, isVerified));
    }
}