using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Usuario
    {
        public string Nombre { get; set; } = "";
        public string Password { get; set; } = "";
        public int NroAfiliado { get; set; }
    }
}
