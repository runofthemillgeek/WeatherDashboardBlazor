using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherDashboard.Models;

namespace WeatherDashboard.Services
{
    interface IWeatherService
    {
        Task<Location[]> GetLocations(string[] searchLocations);
    }
}
