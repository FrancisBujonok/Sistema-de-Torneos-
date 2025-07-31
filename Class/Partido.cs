using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Torneos;

namespace Sistema_Torneos
{
    public class Partido
    {
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public int GolesLocal { get; set; } 
        public int GolesVisitante { get; set; }
        public string Estado { get; set;}
        public string MostrarResultado { get; set;}
        public string Ganador { get; set;}

        public Partido(string equipolocal, string equipovisitante, string estado, int goleslocal, int golesvisitante, string mostrarresultado, string ganador)
        {
            this.EquipoLocal = equipolocal;
            this.EquipoVisitante = equipovisitante;
            this. Estado = estado;
            this.GolesLocal = goleslocal;
            this.GolesVisitante = golesvisitante;
            this.MostrarResultado = mostrarresultado;
            this.Ganador = ganador;
        }
    }
}
