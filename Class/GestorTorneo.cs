using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Sistema_Torneos;

namespace Sistema_Torneos
{
    public class GestorTorneo
    {
        List<Equipo> equipo { get; set; }
        List<Partido> partido { get; set; }

        public void RegistrarEquipo (string nombre, string ciudad) { }
        public void JugarPartido(string EquipoLocal, string EquipoVisitante, int GolesLocal, int GolesVisitante) { }
    }
}
