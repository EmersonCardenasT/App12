using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Hotel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VHHotelPrincipal : ContentPage
    {

        private bool isIconRed = false;
        public VHHotelPrincipal()
        {
            InitializeComponent();
            // Configurar el WebView para mostrar contenido HTML con un iframe
            var htmlSource = new HtmlWebViewSource
            {
                Html = @"
                <html>
                    <body>
                        <iframe width='100%' height='100%' src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7827.249230185257!2d-74.65396410000001!3d-11.215385199999993!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x910bc13256cfb9e5%3A0x6fc656d5194ce868!2sSENATI%20R%C3%ADo%20Negro!5e0!3m2!1ses!2spe!4v1724952196679!5m2!1ses!2spe'></iframe>
                    </body>
                </html>"
            };

            webView.Source = htmlSource;


            // Establecer el texto de bienvenida con el nombre del usuario
            lblBienvenida.Text = $"Bienvenido {App.TxtNombre}";
            
        }

        private void iconButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var fontImageSource = button.ImageSource as FontImageSource;
                if (fontImageSource != null)
                {
                    if (isIconRed)
                    {
                        // Cambiar el color del icono a negro
                        fontImageSource.Color = Color.Black;
                    }
                    else
                    {
                        // Cambiar el color del icono a rojo
                        fontImageSource.Color = Color.Red;
                    }

                    // Alternar el estado
                    isIconRed = !isIconRed;
                }
            }
        }
    }
}