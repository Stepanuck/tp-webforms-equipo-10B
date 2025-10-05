using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using dominio.Models;

namespace AccesoDatos
{
    public class VoucherDatos
    {
        public Voucher buscarPorCodigo(string codigo)
        {
            AccesoDatosManager manager = new AccesoDatosManager();
            try
            {

                string consulta = "SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM VOUCHERS WHERE CodigoVoucher = @codigo";
                manager.setearConsulta(consulta);
                manager.setearParametro("@codigo", codigo);
                manager.ejecutarLectura();

                if (manager.Lector.Read())
                {
                    Voucher voucher = new Voucher();
                    voucher.CodigoVoucher = (string)manager.Lector["CodigoVoucher"];


                    if (!(manager.Lector["IdCliente"] is DBNull))
                        voucher.IdCliente = (int)manager.Lector["IdCliente"];

                    if (!(manager.Lector["FechaCanje"] is DBNull))
                        voucher.FechaCanje = (DateTime)manager.Lector["FechaCanje"];

                    if (!(manager.Lector["IdArticulo"] is DBNull))
                        voucher.IdArticulo = (int)manager.Lector["IdArticulo"];

                    return voucher;
                }


                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                manager.cerrarConexion();
            }
        }
    }
}
