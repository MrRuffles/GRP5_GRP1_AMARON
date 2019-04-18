using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AMARON_INTERFACE
{
    /// <summary>
    /// Descripción breve de SlideService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class SlideService : System.Web.Services.WebService
    {
        [WebMethod]
        public AjaxControlToolkit.Slide[] GetSlides()
        {
            AjaxControlToolkit.Slide[] myslides = new AjaxControlToolkit.Slide[4];
            myslides[0] = new AjaxControlToolkit.Slide("Imagenes/ron.jpg", "Ron", "Roncico pa to el mundo");
            myslides[1] = new AjaxControlToolkit.Slide("Imagenes/ginebra.jpg", "Ginegra", "Mejor en chupitazos");
            myslides[2] = new AjaxControlToolkit.Slide("Imagenes/vodka.jpg", "Vodka", "Agua para rusos");
            myslides[3] = new AjaxControlToolkit.Slide("Imagenes/whisky.jpg", "Whisky", "Siempre mejor con hielo");
            return myslides;
        }
    }
}
