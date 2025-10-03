using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio.Models;

namespace presentacion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
           Voucher voucher = new Voucher()
           {           
                CodigoVoucher = voucherBox.Text.Trim(),
                FechaCanje = null,
                IdCliente = null,
                IdArticulo = 0
             };

            if(string.IsNullOrEmpty(voucher.CodigoVoucher))
            {
                ClientScript.RegisterStartupScript(
                    GetType(),
                    "toastError",
                    "new bootstrap.Toast(document.getElementById('toastError')).show();",
                    true
                );
                return;
            }
        
            Session["voucherOk"] = true;
            Session["voucher"] = voucher;
            Response.Redirect("~/ListadoDeArticulos.aspx");
        }
    }
}