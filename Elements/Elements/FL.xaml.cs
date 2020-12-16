using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Elements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FL : ContentPage
    {
        public FL()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOnAsync();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Flashlight.TurnOffAsync();
        }
    }
}