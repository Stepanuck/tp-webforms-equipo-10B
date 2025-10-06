using System;
using AccesoDatos;
using dominio.Models;

namespace negocio
{
    public class VoucherNegocio
    {
        public bool EsVoucherValido(string codigo)
        {
            
            VoucherDatos datos = new VoucherDatos();
            try
            {
               
                Voucher voucher = datos.buscarPorCodigo(codigo);

                
                if (voucher != null && voucher.IdCliente == null)
                {
                    return true;
                }

                return false; 
            }
            catch (Exception ex)
            {
              
                throw ex;
            }
        }
        
        public void canjear(string codigo, int idCliente, int idArticulo)
        {
            VoucherDatos datos = new VoucherDatos();
            try
            {
                datos.canjearVoucher(codigo, idCliente, idArticulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}