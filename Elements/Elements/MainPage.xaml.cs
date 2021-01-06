using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elements
{
    public partial class MainPage : ContentPage
    {
        StackLayout stack = new StackLayout();
        List<Button> buttons = new List<Button>();
        public MainPage()
        {

            for (int i = 0; i < 8; i++)
            {
                Button btn = new Button()
                {
                    Text = $"Page {i}"
                };
                buttons.Add(btn);
                stack.Children.Add(btn);
            }
            Content = stack;
            buttons[0].Text = "Звонок";
            buttons[0].Clicked += MainPage_Clicked1;
            buttons[1].Text = "Вибрация";
            buttons[1].Clicked += MainPage_Clicked2;
            buttons[2].Text = "Фонарик";
            buttons[2].Clicked += MainPage_Clicked3;
            buttons[3].Text = "Корпусы";
            buttons[3].Clicked += MainPage_Clicked4;
            buttons[4].Text = "TextToSpeech";
            buttons[4].Clicked += MainPage_Clicked5;
            buttons[5].Text = "Map";
            buttons[5].Clicked += MainPage_Clicked6;
            buttons[6].Text = "spinner";
            buttons[6].Clicked += MainPage_Clicked7;
            buttons[7].Text = "Text Scale";
            buttons[7].Clicked += MainPage_Clicked8;
        }

        private async void MainPage_Clicked8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Textscale());
        }

        private async void MainPage_Clicked6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Map());
        } 
        private async void MainPage_Clicked7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextSpinner());
        }

        private async void MainPage_Clicked5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Texttospeech());
        }

        private async void MainPage_Clicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Link());
        }

        private async void MainPage_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FL());
        }

        private async void MainPage_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vibr());
        }

        private async void MainPage_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhoneInfo());
        }
    }
}
