using KaysBookClub.Api;
using KaysBookClub.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KaysBookClub.Test;

public class WeatherForecastControllerTests
{
    [Fact]
    public void Test1()
    {
        var controller = new WeatherForecastController(new Logger<WeatherForecastController>(null));
        Assert.IsType<IEnumerable<WeatherForecast>>(controller.Get());
    }
}