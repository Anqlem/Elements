using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Texttospeech : ContentPage
    {
        float Volume_;
        float Pitch_;
        public Texttospeech()
        {
            InitializeComponent();
            Volume_ = (float)vol.Value;
            Pitch_ = (float)pit.Value;
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {
            SpeechOptions settings = new SpeechOptions()
            {
                Volume = Volume_,
                Pitch = Pitch_,
            };
            if (text.Text != null) { await Xamarin.Essentials.TextToSpeech.SpeakAsync(text.Text, settings); }
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Volume_ = (float)vol.Value;
        }

        private void Slider_ValueChanged_1(object sender, ValueChangedEventArgs e)
        {
            Pitch_ = (float)pit.Value;
        }
    }
}