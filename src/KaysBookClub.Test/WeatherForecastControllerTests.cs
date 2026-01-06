using KaysBookClub.Api;
using KaysBookClub.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KaysBookClub.Test;

public class WeatherForecastControllerTests
{
    [Fact]
    public void ValueIsAnInteger()
    {
        Assert.IsType<int>(1.1);
    }
    
    [Fact]
    public void ValueIsABoolean()
    {
        Assert.IsType<bool>(true);
    }
}