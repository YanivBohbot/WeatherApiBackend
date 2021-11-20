using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TEST25.Services
{


    public class WeatherService : IWeatherService
    {
            private HttpClient _httpClient;
            private string api_key = "Kf5XZlp85Td6JrMyYKbjGzik6qWhpcEB";
            private string Base_URL = "http://dataservice.accuweather.com";

            public WeatherService(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            public async Task<string> GetResult(string cityName)
            {
                
             string Request_URL = $"{this.Base_URL}/locations/v1/cities/autocomplete?apikey={this.api_key}&q={cityName}";
                    
             var response = await _httpClient.GetAsync(Request_URL);
               
             return await response.Content.ReadAsStringAsync();
            
        
            }



        public async Task<string>  GetCurrentWeather(string city_key)
        {

            string Request_URL = $"{this.Base_URL}/currentconditions/v1/{city_key}?apikey={this.api_key}";

            var response = await _httpClient.GetAsync(Request_URL);

            return await response.Content.ReadAsStringAsync();
        }
    }

   
}
