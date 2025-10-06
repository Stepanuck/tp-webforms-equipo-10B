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

        public void insertarNuevo(Cliente nuevo)
        {
            AccesoDatosManager manager = new AccesoDatosManager();
            try
            {
                string consulta = "INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) VALUES (@doc, @nombre, @apellido, @email, @dir, @ciudad, @cp)";
                manager.setearConsulta(consulta);

                
                manager.setearParametro("@doc", nuevo.Documento);
                manager.setearParametro("@nombre", nuevo.Nombre);
                manager.setearParametro("@apellido", nuevo.Apellido);
                manager.setearParametro("@email", nuevo.Email);
                manager.setearParametro("@dir", nuevo.Direccion);
                manager.setearParametro("@ciudad", nuevo.Ciudad);
                manager.setearParametro("@cp", nuevo.CP);

                manager.ejecutarAccion(); 
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