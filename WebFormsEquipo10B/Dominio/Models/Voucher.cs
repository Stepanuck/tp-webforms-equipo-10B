using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio.Models
{
    public class Voucher
        {
            public string CodigoVoucher { get; set; } 
            public int? IdCliente { get; set; } 
            public DateTime? FechaCanje { get; set; } 
            public int IdArticulo { get; set; } 
        }

    
}
