using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TEST25.Models;
using TEST25.Services;

namespace TEST25.Controllers
{
    [ApiController]
    [Route("Weather")]
    public class WeatherController : ControllerBase
    {

        
        private readonly IWeatherService _weatherService;


        public WeatherController(IWeatherService weatherService)
        {

            _weatherService = weatherService;

        }


        [HttpGet]
        [Route("auto/{city_name}")]
        public async Task<string> GetAutoComplete(string city_name)
        {

           return await _weatherService.GetResult(city_name);

        }


        [HttpGet]
        [Route("current/{key_city}")]
        public async Task<string> GetCurrentCondition(string key_city)
        {

            return await _weatherService.GetCurrentWeather(key_city);

        }

    }
}
