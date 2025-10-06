using System;
using AccesoDatos;
using dominio.Models;

namespace negocio
{
    public class ClienteNegocio
    {
        public Cliente buscarPorDni(string dni)
        {
            ClienteDatos datos = new ClienteDatos();
            try
            {
                
                return datos.buscarPorDni(dni);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void altaCliente(Cliente nuevo)
        {
            ClienteDatos datos = new ClienteDatos();
            try
            {
         
                if (nuevo == null)
                    throw new Exception("No se proporcionaron datos del cliente.");

                if (string.IsNullOrEmpty(nuevo.Nombre) || string.IsNullOrEmpty(nuevo.Apellido) || string.IsNullOrEmpty(nuevo.Documento))
                    throw new Exception("Nombre, Apellido y Documento son campos requeridos.");

                if (string.IsNullOrEmpty(nuevo.Email) || !nuevo.Email.Contains("@"))
                    throw new Exception("El formato del email no es válido.");

                
                datos.insertarNuevo(nuevo);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}