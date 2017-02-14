using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace PartielWeather
{
	public class DataRetriever
	{
		public static async Task<ApiData> GetApiData(string zipCode)
		{
			//Sign up for a free API key at http://openweathermap.org/appid  
			string key = "5afa082a6f15e0a5ac2e5956035b72a9";
			string queryString = "http://samples.openweathermap.org/data/2.5/weather?zip="
				+ zipCode + ",us&appid=" + key;

			HttpClient client = new HttpClient();
			dynamic results = await Service.getDataFromService(queryString).ConfigureAwait(false);
			ApiData weather = new ApiData();


			if (results["weather"] != null)
			{
				weather.Title = results["weather"];
				weather.Temperature = (string)results["main"]["temp"] + " F";
				weather.Wind = (string)results["wind"]["speed"] + " mph";
				weather.Humidity = (string)results["main"]["humidity"] + " %";
				weather.Visibility = (string)results["weather"][0]["main"];

				DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
				DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
				DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
				weather.Sunrise = sunrise.ToString() + " UTC";
				weather.Sunset = sunset.ToString() + " UTC";
				return weather;
			}
			else
			{
				return null;
			}
		}
	}
}
