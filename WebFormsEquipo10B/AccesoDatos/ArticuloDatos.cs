using dominio.Models;
using System;
using System.Collections.Generic;

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

                foreach (Articulo articulo in lista)
                {
                    articulo.Imagenes = cargarImagenes(articulo.Id);
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

        
        public List<Imagen> cargarImagenes(int idArticulo)
        {
            List<Imagen> listaImagenes = new List<Imagen>();
            AccesoDatosManager manager = new AccesoDatosManager();
            try
            {
                string consulta = "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArticulo";
                manager.setearConsulta(consulta);
                manager.setearParametro("@idArticulo", idArticulo);
                manager.ejecutarLectura();

                while (manager.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)manager.Lector["Id"];
                    aux.IdArticulo = (int)manager.Lector["IdArticulo"];
                    
                    aux.NombreArchivo = (string)manager.Lector["ImagenUrl"];
                    listaImagenes.Add(aux);
                }

                return listaImagenes;
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