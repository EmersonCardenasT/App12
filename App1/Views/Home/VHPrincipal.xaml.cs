using App1.Views.Login;
using App1.Views.Registrarse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VHPrincipal : ContentPage
    {
        public VHPrincipal()
        {
            InitializeComponent();
        }

        private async void btn_inicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VLLogin());
        }

        private async void btn_registrarse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VRRegistrarse());
        }
    }
}