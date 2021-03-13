using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PX3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Login_Clicked(object sender, EventArgs e)
        { 

            if (string.IsNullOrEmpty(bEmail.Text))
            {
                await DisplayAlert("Advertencia", "Campo Email y/o Password no pueden estar vacios", "OK");
            }
            else
            {
                await DisplayAlert("Bienvenido", (bEmail.Text), "Ok");
            }
            if (string.IsNullOrEmpty(Pw.Text))
            {
                await DisplayAlert("Advertencia", "Campo Email y/o Password no pueden estar vacios", "OK");
            }
            else
            {
                await DisplayAlert("Bienvenido", (bEmail.Text), "Ok");
            }

        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}
