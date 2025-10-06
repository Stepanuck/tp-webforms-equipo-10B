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
           
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                
                List<Articulo> lista = datos.listar();
                return lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
