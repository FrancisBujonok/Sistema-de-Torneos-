using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Torneos
{
    public class Partido
    {
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public int GolesLocal { get; set; } 
        public int GolesVisitante { get; set; }
    }
}
