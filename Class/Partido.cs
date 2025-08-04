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
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public int GolesLocal { get; set; } 
        public int GolesVisitante { get; set; }
        public string Estado { get; set;}
        public string MostrarResultado { get; set;}
        public string Ganador { get; set;}

        public Partido(Equipo equipolocal, Equipo equipovisitante, string estado, int goleslocal, int golesvisitante, string mostrarresultado, string ganador)
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
