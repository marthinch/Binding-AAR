using BindingAAR.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace BindingAAR
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonVowel_Clicked(object sender, EventArgs e)
        {
            int numVowels = DependencyService.Get<IAarBindingService>().NumberOfVowels(EntryValue.Text);

            string message = "number of vowels " + numVowels;

            await DisplayAlert("", message, "OK");
        }

        private async void ButtonConsonant_Clicked(object sender, EventArgs e)
        {
            int numConsonants = DependencyService.Get<IAarBindingService>().NumberOfConsonants(EntryValue.Text);

            string message = "number of consonants " + numConsonants;

            await DisplayAlert("", message, "OK");
        }
    }
}
