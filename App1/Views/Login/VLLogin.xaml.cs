using App1.Views.Hotel;
using App1.Views.Registrarse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VLLogin : ContentPage
    {

        public VLLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContraseña.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                lblRespuesta.Text = "Todos los campos son obligatorios";
                return;
            }

            if (App.TxtUsuario == user && App.TxtContraseña == password)
            {
                lblRespuesta.Text = "Exitoso!";
                await Navigation.PushModalAsync(new VHHotelPrincipal());
            }
            else
            {
                lblRespuesta.Text = "Credenciales incorrectas";
            }

        }

        private async void btnRegistrare_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync (new VRRegistrarse());
        }
    }
}