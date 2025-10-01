using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; } = new Marca();
        public Categoria Categoria { get; set; } = new Categoria();
        public decimal Precio { get; set; }
        
        public List<Imagen> Imagenes { get; set; } = new List<Imagen>();



        public Articulo()
        {
            Marca = new Marca();
            Categoria = new Categoria();
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
