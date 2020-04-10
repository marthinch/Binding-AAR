using BindingAAR.Droid.Services;
using BindingAAR.Services;
using Com.Xamarin.Textcounter;
using Xamarin.Forms;

[assembly: Dependency(typeof(AarBindingService))]
namespace BindingAAR.Droid.Services
{
    public class AarBindingService : IAarBindingService
    {
        public int NumberOfConsonants(string input)
        {
            return TextCounter.NumConsonants(input);
        }

        public int NumberOfVowels(string input)
        {
            return TextCounter.NumVowels(input);
        }
    }
}