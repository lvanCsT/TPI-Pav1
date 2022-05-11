using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Afiliado
    {
        public int NroAfiliado { get; set; }
        public int Categoria { get; set; } = 0;
        public string Apellido { get; set; } = "";
        public string Nombre { get; set; } = "";
        public int TipoDoc { get; set; } = 0;

        public int NroDoc { get; set; } = 0;
        public string FechaNacimiento { get; set; } = "";

        public string Calle { get; set; } = "";
        public int NroCalle { get; set; } = 0;

        public int Barrio { get; set; } = 0;

        //public Afiliado(int codcategoria, string apellido, string nombre, int tipodoc, int nrodoc, string fechanacimiento, string calle, int nrocalle, int barrio)
        //{
        //    CodCategoria = codcategoria;
        //    Nombre = nombre;
        //    Apellido = apellido;
        //    TipoDoc = tipodoc;
        //    NroDoc = nrodoc;
        //    FechaNacimiento = fechanacimiento;
        //    Calle = calle;
        //    NroCalle = nrocalle;
        //    Barrio = barrio;
        //}   


    }
}
