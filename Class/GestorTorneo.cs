using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public GestorTorneo()
        {
            this.equipo = new List<Equipo>();
            this.partido = new List<Partido>();
        }
        public void RegistrarEquipo (string nombre, string ciudad) 
            {
            Equipo nuevoEquipo = new Equipo(nombre, ciudad);
            this.equipo.Add(nuevoEquipo);
            Console.WriteLine($"El equipo '{nombre}' de '{ciudad}' ha sido registrado con éxito.");
            Console.ReadKey();
        }
        public void JugarPartido(Equipo EquipoLocal, Equipo EquipoVisitante, int GolesLocal, int GolesVisitante) { }
        public void VerTablaPosiciones()
        {
            Console.WriteLine("--- TABLA DE POSICIONES ---");

            if (this.equipo.Count == 0)
            {
                Console.WriteLine("No hay equipos registrados en el torneo.");
            }
            else
            {
                foreach (Equipo equipo in this.equipo)
                {
                    Console.WriteLine($"Equipo: {equipo.Nombre} - Puntos: {equipo.Puntos}");
                    Console.ReadKey();
                }
            }
        }
        public void VerHistorialPartidos ()
        {
            Console.WriteLine("- HISTORIAL DE PARTIDOS. ");

            if (this.partido.Count == 0)
            {
                Console.WriteLine("No se ha jugado ningún partido todavía.");
            }
            else
            {
                foreach (Partido partido in this.partido)
                {
                    Console.WriteLine($"Partido: {partido.EquipoLocal.Nombre} {partido.GolesLocal} - {partido.GolesVisitante} {partido.EquipoVisitante.Nombre}");
                    Console.ReadKey();
                }
            }
        }
    }
}
