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
        public void RegistrarEquipo(string nombre, string ciudad)
        {
            Equipo nuevoEquipo = new Equipo(nombre, ciudad);
            this.equipo.Add(nuevoEquipo);
            Console.WriteLine($"El equipo '{nombre}' de '{ciudad}' ha sido registrado con éxito.");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public void JugarPartido(string nombreLocal, string nombreVisitante, int golesLocal, int golesVisitante)
        {
   
            Equipo equipoLocal = this.equipo.FirstOrDefault(e => e.Nombre == nombreLocal);
            Equipo equipoVisitante = this.equipo.FirstOrDefault(e => e.Nombre == nombreVisitante);
            if (equipoLocal == null)
            {
                Console.WriteLine($"Error: El equipo '{nombreLocal}' no está registrado.");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                return; 
            }

            if (equipoVisitante == null)
            {
                Console.WriteLine($"Error: El equipo '{nombreVisitante}' no está registrado.");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                return;
            }
            Partido nuevoPartido = new Partido(equipoLocal, equipoVisitante, golesLocal, golesVisitante);
            this.partido.Add(nuevoPartido);

            equipoLocal.GolesAFavor += golesLocal;
            equipoLocal.GolesEnContra += golesVisitante;
            equipoVisitante.GolesAFavor += golesVisitante;
            equipoVisitante.GolesEnContra += golesLocal;

            if (golesLocal > golesVisitante)
            {
                equipoLocal.Puntos += 3;
                Console.WriteLine($"{equipoLocal.Nombre} ha ganado el partido.");
            }
            else if (golesVisitante > golesLocal)
            {
                equipoVisitante.Puntos += 3;
                Console.WriteLine($"{equipoVisitante.Nombre} ha ganado el partido.");
            }
            else
            {
                equipoLocal.Puntos += 1;
                equipoVisitante.Puntos += 1;
                Console.WriteLine("El partido ha terminado en empate.");
            }

            Console.WriteLine($"Resultado: {equipoLocal.Nombre} {golesLocal} - {golesVisitante} {equipoVisitante.Nombre}");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
<<<<<<< HEAD
=======
        public void JugarPartido(Equipo EquipoLocal, Equipo EquipoVisitante, int GolesLocal, int GolesVisitante) { }
>>>>>>> 19a0423ed0500f6c56914e52759b7b1114324ec2
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
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
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
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
