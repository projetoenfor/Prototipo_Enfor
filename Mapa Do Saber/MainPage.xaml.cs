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

        private async void Button_Clicked_Professor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginProfessor());
        }

        private async void Button_Clicked_Aluno(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginAlunos());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page());
        }
    }
}
