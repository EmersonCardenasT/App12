using App1.Views.Hotel;
using App1.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Registrarse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VRRegistrarse : ContentPage
    {
        public VRRegistrarse()
        {
            InitializeComponent();
        }

        private async void btnRegistrarse_Clicked(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string apellidos = txtApellidos.Text;
            string nombres = txtNombre.Text;
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos) 
                || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                lblRespuesta.Text = "Todos los campos son obligatorios";
                return;
            }
            
            App.TxtNombre = nombres;
            App.TxtApellido = apellidos;
            App.TxtUsuario = usuario;
            App.TxtContraseña = contraseña;

            lblRespuesta.Text = "Registro Exitoso!";
            await Navigation.PushModalAsync(new VLLogin());

        }

        private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VLLogin());
        }
    }
}