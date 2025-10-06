using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio.Models;
using negocio;

namespace presentacion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string codigo = voucherBox.Text.Trim(); ///Leemos el codigo, si viene vacio o incorrecto, mostramos el toast de error 
            VoucherNegocio negocio = new VoucherNegocio();
            if(string.IsNullOrWhiteSpace(codigo))//Si el codigo es nulo, vacio o solo espacios
            {
                ClientScript.RegisterStartupScript(//Muestra el toast de error
                          GetType(), "toastError",
                          "new bootstrap.Toast(document.getElementById('toastError')).show();", true);
                return;
            }
            bool valido;//flag para guardar si el voucher es valido o no 
            try
            {
                valido = negocio.EsVoucherValido(codigo);//validamos el voucher
            }catch
            {
                               ClientScript.RegisterStartupScript(//Si hay un error en la validacion, mostramos el toast de error
                          GetType(), "toastError",
                          "new bootstrap.Toast(document.getElementById('toastError')).show();", true);
                return;
            }
            if (!valido)//Si el voucher no es valido, mostramos el toast de error
            {
                ClientScript.RegisterStartupScript(
                          GetType(), "toastError",
                          "new bootstrap.Toast(document.getElementById('toastError')).show();", true);
                return;
            }//Si llegamos hasta aca, el voucher es valido, lo guardamos en session y redirigimos al listado de articulos
            Voucher voucher = new Voucher();
            {
                voucher.CodigoVoucher = codigo;
                voucher.FechaCanje = null;
                voucher.IdCliente = null;
                voucher.IdArticulo = 0;
            }
            Session["Voucher"] = voucher;
            Session["VoucherOK"] = true;
            Response.Redirect("~/ListadoDeArticulos.aspx");

        }
    }
}