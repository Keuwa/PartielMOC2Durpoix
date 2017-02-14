using System;
namespace PartielWeather
{
	public class Api
	{
		string Title { get; set; }
		string Temperature { get; set; }
		string Sunrise { get; set; }
		string Wind { get; set; }
		string Humidity { get; set; }
		string Sunset { get; set; }
		string Visibility { get; set; }

		public Api()
		{
			this.Title = "";
			this.Temperature = "";
			this.Sunrise = "";
			this.Wind = "";
			this.Humidity = "";
			this.Sunset = "";
			this.Visibility = "";
		}
	}
}
