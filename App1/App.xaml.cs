using App1.Views.Home;
using App1.Views.Hotel;
using App1.Views.Login;
using System;
using System.Security.Cryptography.X509Certificates;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public static string TxtNombre { get; set; }
        public static string TxtApellido { get; set; }
        public static string TxtUsuario { get; set; }
        public static string TxtContraseña { get; set; }

        public App()
        {
            InitializeComponent();

            //MainPage = new VHFormulario();
            //MainPage = new VHHotelPrincipal();
            //MainPage = new NavigationPage(new VHPrincipal());
            MainPage = new VHPrincipal();
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
