using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Weather.WeatherStation.Pages
{
    public class Index_Tests : WeatherStationWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
