using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    internal class Atencion
    {
        public int NroExpediente { get; set; }
        public int Categoria { get; set; } = 0;
        public int NroAfiliado { get; set; }
        public string FechaAtencion { get; set; } = "";
        public int Matricula { get; set; }

    }
}
