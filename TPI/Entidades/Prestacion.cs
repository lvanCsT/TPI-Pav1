using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    internal class Prestacion
    {
        public int CodPrestacion { get; set; }
        public string Descripcion { get; set; } = "";
        public int EdadMinima { get; set; } = 0;
    }
}
