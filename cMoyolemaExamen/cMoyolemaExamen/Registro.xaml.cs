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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            
            InitializeComponent();
            lblUsuario.Text = "usuario conectado:"+usuario;

        }

        private void btnpagomensual_Clicked(object sender, EventArgs e)
        {
            
            string montoi = txtmontoinicial.Text;
            try { 
            if (!montoi.ToCharArray().All(Char.IsDigit))
            {
                DisplayAlert("Error", "El monto incial debe ser numerico", "Back");
                return;
            }
            else {
                Double pInicial = Convert.ToDouble(txtmontoinicial.Text);
                if (pInicial>0 && pInicial<4000) {
                double pfinm = ((4000-pInicial)/5)+5%4000;
                lblmensual.Text = pfinm.ToString();
            } else {
                DisplayAlert("alerta","Monto Inicial No Valido Intente de Nuevo","cerrar");
            }
            }
            }
            catch { }

        }

        private void btnguardari_Clicked(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string montoin = txtmontoinicial.Text;
            string pagoi = lblmensual.Text;
            string usuario1 = lblUsuario.Text;
            DisplayAlert("alerta","Datos Guardados con Exito","cerrar");
            Navigation.PushAsync(new Resumen(nombre,montoin,pagoi,usuario1));

        }
    }
}