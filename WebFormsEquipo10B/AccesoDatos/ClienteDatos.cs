using System;
using System.Collections.Generic;
using dominio.Models;

namespace AccesoDatos
{
    public class ClienteDatos
    {
        public Cliente buscarPorDni(string dni)
        {
            AccesoDatosManager manager = new AccesoDatosManager();
            try
            {
                string consulta = "SELECT Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP FROM Clientes WHERE Documento = @dni";
                manager.setearConsulta(consulta);
                manager.setearParametro("@dni", dni);
                manager.ejecutarLectura();

                if (manager.Lector.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (int)manager.Lector["Id"];
                    cliente.Documento = (string)manager.Lector["Documento"];
                    cliente.Nombre = (string)manager.Lector["Nombre"];
                    cliente.Apellido = (string)manager.Lector["Apellido"];
                    cliente.Email = (string)manager.Lector["Email"];
                    cliente.Direccion = (string)manager.Lector["Direccion"];
                    cliente.Ciudad = (string)manager.Lector["Ciudad"];
                    cliente.CP = manager.Lector["CP"].ToString(); 

                    return cliente;
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