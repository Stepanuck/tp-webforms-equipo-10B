using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio.Models;

namespace presentacion
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){ }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            var voucherEnSesion = Session["Voucher"] as Voucher;

            if (voucherEnSesion == null)
            {
                Response.Redirect("~/Default.aspx");
                return; //Si no tenemos el voucher en sesion, redirigimos a la pagina principal
            }
           
            int idArticulo = voucherEnSesion.IdArticulo;
            if(idArticulo <= 0)
            {
                Response.Redirect("~/ListadoDeArticulos.aspx");
                return; //Si no tenemos el id del articulo en el voucher, redirigimos a la pagina principal
            }

            Cliente nuevoCliente = new Cliente();
            try
            {
                nuevoCliente.Documento = txtDni.Text.Trim();
                nuevoCliente.Nombre = txtNombre.Text.Trim();
                nuevoCliente.Apellido = txtApellido.Text.Trim();
                nuevoCliente.Email = txtEmail.Text.Trim();
                nuevoCliente.Direccion = txtDireccion.Text.Trim();
                nuevoCliente.Ciudad = txtCiudad.Text.Trim();
                nuevoCliente.CP = txtCp.Text.Trim();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al capturar los datos del cliente: " + ex.Message);

            }
            PromoNegocio promoNegocio = new PromoNegocio();
            try
            {
                promoNegocio.registrarParticipacion(
                  codigoVoucher: voucherEnSesion.CodigoVoucher,
                  idArticulo: idArticulo,
                   cliente : nuevoCliente
                );

                Session.Remove("Voucher");
                Session.Remove("VoucherOk");
                Session["CanjeOk"] = true;

                ClientScript.RegisterStartupScript(
                    GetType(),
                    "toastSucces",
                    "showToast('toastSucces'); salir('/Default.aspx');",
                    true
                    );
            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(
                    GetType(),
                    "toastError",
                    "showToast('toastError'); salir('/Default.aspx');",
                    true
                    );
            }
        }
        }
}