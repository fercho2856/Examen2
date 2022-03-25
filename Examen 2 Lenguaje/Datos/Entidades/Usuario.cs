using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public string Codigo { get; set; }
        public string Clave { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigo , string clave)
        {
            this.Codigo = codigo;
            Clave = clave;
           
        }
    }
}
