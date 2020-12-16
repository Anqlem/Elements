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
    public partial class Vibr : ContentPage
    {
        public Vibr()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Or use specified time
                var duration = TimeSpan.FromSeconds(100);
                Vibration.Vibrate(duration);
            }
            catch (FeatureNotSupportedException ex)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Vibration.Cancel();
            }
            catch (FeatureNotSupportedException ex)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}