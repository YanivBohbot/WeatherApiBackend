using System.Threading.Tasks;

namespace TEST25.Services
{
    public interface IWeatherService
        {
            Task<string> GetResult(string cityName);
            Task<string> GetCurrentWeather(string city_key);


        //public string GetResults(string cityName);
    }

   
}
