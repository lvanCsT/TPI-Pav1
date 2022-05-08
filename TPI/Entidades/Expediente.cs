using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    internal class Expediente
    {
        public int NroExpediente { get; set; }

        public string FechaInicio { get; set; } = "";

        public int Reintegro { get; set; } = 0;
    }
}
