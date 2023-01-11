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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre,string montoin,string pagoi,string usuario1)
        {
            InitializeComponent();
            lblusuario.Text = "usuario conectado:" + usuario1;
            lblnombre.Text = nombre;
            double monto1 = double.Parse(montoin);
            double pago1 = double.Parse(pagoi);
            double total = (pago1*5)+monto1;
            lbltotal.Text = Convert.ToString(total);
        }

        private void btnacerca_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("alerta","este proyecto fue desarrollado por Cristhian Moyolema","cerrar");
        }
    }
}