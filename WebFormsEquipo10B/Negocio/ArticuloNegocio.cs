using System;
using System.Collections.Generic;
using dominio.Models;
using AccesoDatos;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            // Creamos una instancia de la clase de acceso a datos
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                // La capa de negocio llama al método de la capa de datos
                List<Articulo> lista = datos.listar();
                return lista;
            }
            catch (Exception ex)
            {
                // Re-lanzamos la excepción para que sea manejada por la capa de presentación
                throw ex;
            }
        }
    }
}
