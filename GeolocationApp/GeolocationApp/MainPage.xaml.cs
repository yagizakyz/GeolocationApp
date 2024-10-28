using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GeolocationApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void locationGet_Clicked(object sender, EventArgs e)
        {
            var result = await Geolocation.GetLocationAsync(new
                GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(30)));
            locaTXT.Text = $"{result.Latitude}, {result.Longitude}";
        }

        [Obsolete]
        private void click_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com.tr/maps/place/" + locaTXT.Text));
        }
    }
}
