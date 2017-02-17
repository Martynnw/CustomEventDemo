using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CustomEventDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void FastButton_Clicked(object sender, EventArgs e)
        {
            await TrackEvent(100);
        }

        private async void SlowerButton_Clicked(object sender, EventArgs e)
        {
            await TrackEvent(300);
        }

        private async void SlowestButton_Clicked(object sender, EventArgs e)
        {
            await TrackEvent(500);
        }

        private async Task TrackEvent(int delay)
        {
            await Task.Delay(delay);
            HockeyApp.MetricsManager.TrackEvent("ButtonClick", new Dictionary<string, string> { { "property", "value" } }, new Dictionary<string, double> { { "delay", delay } });
        }
    }
}
