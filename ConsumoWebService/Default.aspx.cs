using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumoWebService
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sumar(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

            CalculadoraWS.CalculadoraWSSoapClient servicio = new CalculadoraWS.CalculadoraWSSoapClient();

            lblRespuesta.Text = servicio.sumar(num1, num2) + "";
        }


        /*Recordar habilitar la sesion en el lado del cliente, en el web config*/

        /*
         *  <system.serviceModel>
                <bindings>
                    <basicHttpBinding>
                            <binding name="CalculadoraWSSoap" 
                             allowCookies="true"/>
         */
        protected void Restar(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1Resta.Text);
            int num2 = Convert.ToInt32(txtNum2Resta.Text);

            CalculadoraWS.CalculadoraWSSoapClient servicio = new CalculadoraWS.CalculadoraWSSoapClient();

            lblRespuestaResta.Text = servicio.restar(num1, num2) + "";

            /*Se asocia la lista a la grilla*/
            gridCalculos.DataSource = servicio.getCalculos();
            /*Se enlazan los datos para que se muestren*/
            gridCalculos.DataBind();
        }
    }
}