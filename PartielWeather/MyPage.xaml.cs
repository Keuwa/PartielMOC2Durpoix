using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PartielWeather
{
	public partial class MyPage : ContentPage
	{
		public MyPage()
		{
			InitializeComponent();
			getWeatherBtn.Clicked += GetWeatherBtn_Clicked;

			//Set the default binding to a default object for now  
			this.BindingContext = new ApiData();
		}
		private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
		{
			ApiData apiData = await DataRetriever.GetApiData("94040");
			if(apiData!=null)
				getWeatherBtn.Text = apiData.Title;
		}
	}
}
