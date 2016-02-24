using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatorWS
{
    /// <summary>
    /// Descripción breve de CalculadoraWS
    /// </summary>
    [WebService(Namespace = "http://eam.edu.co/webService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculadoraWS : System.Web.Services.WebService
    {

        /*Para este ejercicio se crearon 2 proyectos en la misma solucion
            --El nuevo proyecto es un webform asp
            --Añadir la referencia al web service
            --Añadir el web service teniendo en cuenta la url del web service (Donde se listan
              los metodos)*/

        [WebMethod(Description = "Este metodo suma 2 numeros")]
        public int sumar(int num1, int num2)
        {
            return num1 + num2;
        }



        /*CON SESION HABILITADAS*/
        [WebMethod(EnableSession = true,
                   Description = "Este metodo resta 2 numeros y almacena el proceso en sesion")]
        public int restar(int num1, int num2)
        {

            List<string> calculos;

            if (Session["Calculos"] == null)
            {
                calculos = new List<string>();
            }
            else
            {
                calculos = (List<string>)Session["Calculos"];
            }

            calculos.Add(num1.ToString() + "-" + num2.ToString() + "=" + (num1 - num2));
            Session["Calculos"] = calculos;
            return num1 - num2;
        }



        /*CON SESION HABILITADAS*/
        [WebMethod(EnableSession = true,
                   Description = "Retorna el historial de todas las restas realizadas")]
        public List<string> getCalculos()
        {
            if (Session["Calculos"] == null)
            {
                List<string> calculos = new List<string>();
                calculos.Add("No hay operaciones");
                return calculos;
            }
            else
            {
                return (List<string>)Session["Calculos"];
            }
        }


        /******************************************************************/
        /**********************APLICAR SOBRECARGA DE METODOS***************/
        /******************************************************************/

        /*Para hacer sobrecarga de metodos recordar modificar el atributo 
       [WebServiceBinding(ConformsTo = WsiProfiles.?)], y pasarlo a 
      .none*/
        //[WebMethod(Description = "Este metodo suma 2 numeros",
        //           MessageName = "Respuesta suma dos numeros")]
        //public int sumar(int num1, int num2, int num3)
        //{
        //    return num1 + num2 + num3;
        //} 
    }
}
