using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Cliente
    {
        public int Id { get; set; }
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; } 
        public Cliente(int id, string nombre, string apellido, string email, string direccion, string ciudad, int codigoPostal)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Direccion = direccion;
            Ciudad = ciudad;
            CodigoPostal = codigoPostal;
        }
        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Email}";
        }
    }
}
