using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cMoyolemaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contraseña = "uisrael2023";

            if (usuario==txtusuario.Text&& contraseña==txtcontraseña.Text){

                Navigation.PushAsync(new Registro(usuario));
            }
            else {
                DisplayAlert("alerta","LOS DATOS QUE INGRESO SON INCORRECTOS","cerrar");
            }
        }
    }
}