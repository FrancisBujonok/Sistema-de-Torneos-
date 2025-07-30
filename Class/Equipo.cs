using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Torneos
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public int Puntos { get; set; }
        public int GolesAFavor { get; set; }
        public int GolesEnContra { get; set; } // Changed type from string to int  
        public string Ciudad { get; set; }

        public Equipo(string nombre, int puntos, int golesafavor, int golesencontra, string ciudad)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Puntos = puntos;
            this.GolesAFavor = golesafavor;
            this.GolesEnContra = golesencontra;
        }
    }
}
