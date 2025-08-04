using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Torneos;

namespace Sistema_Torneos
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public int Puntos { get; set; }
        public int GolesAFavor { get; set; }
        public int GolesEnContra { get; set; } 
        public string Ciudad { get; set; }

        public Equipo(string nombre, string ciudad)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Puntos = 0;
            this.GolesAFavor = 0;
            this.GolesEnContra = 0;
        }
    }
}
