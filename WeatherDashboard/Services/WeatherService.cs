using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherDashboard.Models;

namespace WeatherDashboard.Services
{
    public class WeatherService : IWeatherService
    {
        private HttpClient client;

        public WeatherService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<Location[]> GetLocations(string[] searchLocations)
        {
            var query = string.Join(",", searchLocations);
            var data = await this.client.GetJsonAsync<Location[]>($"http://localhost:3000/weather?locations=[{query}]");

            //var data = new Location[] {
            //    new Location { Name="Reykjavik", Temperature=32.3, Condition="windy" },
            //    new Location { Name="Akuryeri", Temperature=30.3, Condition="cloudy" }
            //};

            return data;
        }
    }
}
