using System.Collections.Generic;
using static dominio.Models.Voucher;

namespace dominio.Models
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public List<Imagen> Imagenes { get; set; }
        
    }
}
