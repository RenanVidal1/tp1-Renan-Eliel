using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnOk(object sender, EventArgs e)
        {
            if (user.Text == "admin" && password.Text == "123456")
            {
                DisplayAlert("", "Entrou com sucesso", "Ok");
            }
            else if (user.Text == null && password.Text == null)
            {
                DisplayAlert("", "Por favor insira seus dados primeiro", "Ok");
            }
            else
            {
                DisplayAlert("", "Senha ou Id errados", "Ok");
            }
        }

        private void btnClean(object sender, EventArgs e)
        {
            password.Text = "";
            user.Text = "";
        }

        private async void btnCredits(object sender, EventArgs e)
        {
            await DisplayAlert("Créditos",
                                    "Feito por Renan Cunha Teixeira Vidal " +
                                    " e Eliel Camargo de Jesus", 
                               "Sair");
        }
    }
}
