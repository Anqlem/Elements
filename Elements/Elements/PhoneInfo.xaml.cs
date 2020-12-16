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
    public partial class PhoneInfo : ContentPage
    {
        public PhoneInfo()
        {
            InitializeComponent();
        }
        private void btn_Clicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(ent.Text);
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}