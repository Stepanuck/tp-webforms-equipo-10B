using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace presentacion
{
    public partial class MiMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 2. Agregamos la prueba de conexión aquí
            //    !IsPostBack asegura que la prueba solo se ejecute la primera vez que la página carga.
            if (!IsPostBack)
            {
                AccesoDatosManager manager = new AccesoDatosManager();
                if (manager.ProbarConexion())
                {
                    // Escribe en la ventana "Salida" de Visual Studio
                    Debug.WriteLine("¡Conexión a la base de datos exitosa desde la Master Page! ✅");
                }
                else
                {
                    Debug.WriteLine("Falló la conexión a la base de datos desde la Master Page. ❌");
                }

            }
        }
    }
}