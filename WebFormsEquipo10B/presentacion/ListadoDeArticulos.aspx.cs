using AccesoDatos;
using dominio.Models;
using negocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace presentacion
{
    public partial class ListadoDeArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["VoucherOK"] is bool ok) || !ok || Session["Voucher"] == null)
            {
                Response.Redirect("~/Default.aspx");
                return;
            }

            if (!IsPostBack)
            {

                var datos = new ArticuloDatos();
                List<Articulo> lista = datos.listar();
                rptArticulos.DataSource = lista;
                rptArticulos.DataBind();
            }
        }

        protected void rptArticulos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Elegir")
            {
                int idArticulo = int.Parse(e.CommandArgument.ToString());

                var voucher = (Voucher)Session["Voucher"];
                voucher.IdArticulo = idArticulo;
                Session["Voucher"] = voucher;


                Response.Redirect("~/Formulario.aspx");
            }
        }
    }
}