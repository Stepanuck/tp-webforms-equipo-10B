using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio.Models;
namespace presentacion
{
    public partial class ListadoDeArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["VoucherOK"] is bool ok)|| !ok || Session["Voucher"]==null)
                {
                Response.Redirect("~/Default.aspx");
                return;
            }
            Voucher voucher = (Voucher)Session["Voucher"];
           // if (!IsPostBack)
            //{
             //   rptArticulos.DataSource = new Articulo().Listar(voucher.CodigoVoucher);
              //  rptArticulos.DataBind();
            //}
        }
    }
}