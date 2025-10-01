using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public decimal Descuento { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public bool Usado { get; set; }
        public override string ToString()
        {
            return $"{Codigo} - {Descuento * 100}% - Expira: {FechaExpiracion.ToShortDateString()} - Usado: {Usado}";
        }
    }
}
