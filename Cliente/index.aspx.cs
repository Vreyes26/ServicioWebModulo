using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            ServicioModulo.ServicioModuloClient servicioModulo = new ServicioModulo.ServicioModuloClient();

            try
            {
                string total = Convert.ToString(servicioModulo.ObtenerModulo(
                               Convert.ToInt32(inputDividendo.Text),
                               Convert.ToInt32(inputDivisor.Text)));
                lbResultado.Text = "El resultado es: ";
                lbTotal.Text = total;
            }
            catch(Exception)
            {
                lbTotal.Text = "Ha ocurrido un error";
                lbResultado.Text = "";
            }

            inputDividendo.Text = "";
            inputDivisor.Text = "";
        }
    }
}