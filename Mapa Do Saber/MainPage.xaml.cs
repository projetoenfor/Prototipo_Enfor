using Mapa_Do_Saber.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mapa_Do_Saber
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Usuarios(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginUsuarios());
        }

        private async void Button_Clicked_Colaboradores(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginColaboradores());
        }


        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page());
        }
    }
}
