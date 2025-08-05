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
        public string Estado { get; set; }
        public string MostrarResultado { get; set; }
        public string Ganador { get; set; }

        public Partido(Equipo equipoLocal, Equipo equipoVisitante, int golesLocal, int golesVisitante)
        {
            this.EquipoLocal = equipoLocal;
            this.EquipoVisitante = equipoVisitante;
            this.GolesLocal = golesLocal;
            this.GolesVisitante = golesVisitante;
            if (golesLocal > golesVisitante)
            {
                this.Ganador = equipoLocal.Nombre;
                this.Estado = "Finalizado";
            }
            else if (golesVisitante > golesLocal)
            {
                this.Ganador = equipoVisitante.Nombre;
                this.Estado = "Finalizado";
            }
            else
            {
                this.Ganador = "Empate";
                this.Estado = "Finalizado";
            }
        }
    }
}