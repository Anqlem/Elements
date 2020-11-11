using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elements
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Map();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
