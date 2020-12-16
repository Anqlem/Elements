using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Link : ContentPage
    {
        public Link()
        {
            InitializeComponent();
            Browser.Source = "https://www.1a.ee/ru/otsing/?q=%D0%BA%D0%BE%D1%80%D0%BF%D1%83%D1%81%D1%8B";
        }
    }
}