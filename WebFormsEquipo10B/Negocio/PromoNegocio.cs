using System;
using AccesoDatos;
using dominio.Models;

namespace negocio
{
    public class PromoNegocio
    {
        public void registrarParticipacion(string codigoVoucher, int idArticulo, Cliente cliente)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            VoucherNegocio voucherNegocio = new VoucherNegocio();

            try
            {
              
                Cliente clienteExistente = clienteNegocio.buscarPorDni(cliente.Documento);

                int idClienteFinal;

                if (clienteExistente == null)
                {
                    
                    clienteNegocio.altaCliente(cliente);
                    
                    clienteExistente = clienteNegocio.buscarPorDni(cliente.Documento);
                    idClienteFinal = clienteExistente.Id;
                }
                else
                {
                    
                    idClienteFinal = clienteExistente.Id;
                }

                
                voucherNegocio.canjear(codigoVoucher, idClienteFinal, idArticulo);
            }
            catch (Exception ex)
            {
               
                throw ex;
            }
        }
    }
}