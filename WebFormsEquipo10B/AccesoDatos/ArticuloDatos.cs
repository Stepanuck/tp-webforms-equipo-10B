using dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace AccesoDatos
{
    public class ArticuloDatos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatosManager manager = new AccesoDatosManager();

            try
            {

                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio, A.IdMarca, A.IdCategoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id";
                manager.setearConsulta(consulta);
                manager.ejecutarLectura();

                while (manager.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)manager.Lector["Id"];
                    aux.Codigo = (string)manager.Lector["Codigo"];
                    aux.Nombre = (string)manager.Lector["Nombre"];
                    aux.Descripcion = (string)manager.Lector["Descripcion"];


                    if (!(manager.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)manager.Lector["Precio"];


                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)manager.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)manager.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)manager.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)manager.Lector["Categoria"];

                    lista.Add(aux);
                }

                return lista;
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
