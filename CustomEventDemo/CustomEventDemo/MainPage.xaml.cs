using HockeyApp;
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
        private Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ShowPage1_Clicked(object sender, EventArgs e)
        {
            MetricsManager.TrackEvent("Page 1");
            await this.Navigation.PushAsync(new Page1());
        }

        private async void ShowPage2_Clicked(object sender, EventArgs e)
        {
            MetricsManager.TrackEvent("Page 2");
            await this.Navigation.PushAsync(new Page2());
        }

        private async void ShowPage3_Clicked(object sender, EventArgs e)
        {
            MetricsManager.TrackEvent("Page 3");
            await this.Navigation.PushAsync(new Page3());
        }

        private async void DurationEvent_Clicked(object sender, EventArgs e)
        {
            int duration = this.random.Next(3000);
            this.Indicator.IsRunning = true;
            await Task.Delay(duration);
            this.Indicator.IsRunning = false;
            MetricsManager.TrackEvent("DurationEvent", new Dictionary<string, string> { { "property", "value" } }, new Dictionary<string, double> { { "duration", duration} });
        }
    }
}
