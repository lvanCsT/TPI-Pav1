using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Odontologo
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public int tipoOdontologo { get; set; } = -1;
        public string fechaDesde { get; set; } = "";
        public string fechaHasta { get; set; } = "";

    }
}
