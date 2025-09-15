using Ucu.Poo.TestDateFormat;

namespace Library.Tests;
using Library;

public class DateFormatterTests
{
    private DateFormatter _dateFormatter;
    
    [SetUp]
    public void Setup()
    {
        _dateFormatter = new DateFormatter();
    }

    [Test]
    public void ChangeFormat_ValidInputDate_ReturnsConvertedDate()
    { 
        string inputDate = "10/08/2009", expectedDateFormat = "2009-08-10";
        string convertedDate = _dateFormatter.ChangeFormat(inputDate);

        Assert.AreEqual(expectedDateFormat, convertedDate);
    }

    [Test]
    public void ChangeFormat_InvalidInputDate_ReturnsEmpty()
    {
        string inputDate = "10-10-2009", expectedResponse = "", response = _dateFormatter.ChangeFormat(inputDate);
        
        Assert.AreEqual(expectedResponse, response);
    }

    [Test]
    public void ChangeFormat_EmptyInput_ReturnsEmpty()
    {
        string inputDate = "", expectedResponse = "", response = _dateFormatter.ChangeFormat(inputDate);
        
        Assert.AreEqual(inputDate, response);
    }
}