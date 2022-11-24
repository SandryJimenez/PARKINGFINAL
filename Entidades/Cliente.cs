using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        
        public Cliente()
        {

        }

        public Cliente(string iDC, string nombre, string apellido, string genero, string telefono)
        {
            IDC = iDC;
            Nombre = nombre;
            Apellido = apellido;
            Genero = genero;
            Telefono = telefono;
        }

        public string IDC { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }

    }
}
