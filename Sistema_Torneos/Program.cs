using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Torneos;

namespace Sistema_Torneos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorTorneo miTorneo = new GestorTorneo();

            while (true)
            {
                Console.WriteLine("--- SISTEMA DE GESTIÓN DE TORNEOS ---");
                Console.WriteLine("- DEPORTE TOTAL - ");
                Console.WriteLine("1. Registrar nuevo equipo");
                Console.WriteLine("2. Jugar partido");
                Console.WriteLine("3. Ver tabla de posiciones");
                Console.WriteLine("4. Ver historial de partidos");
                Console.WriteLine("5. Salir");
                Console.WriteLine("-----------------------------------");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Ingrese el nombre del equipo: ");
                    string nombreEquipo = Console.ReadLine();
                    Console.Write("Ingrese la ciudad del equipo: ");
                    string ciudadEquipo = Console.ReadLine();
                    miTorneo.RegistrarEquipo(nombreEquipo, ciudadEquipo);
                }
                else if (opcion == "2")
                {
                    Console.Write("Ingrese el nombre del equipo local: ");
                    string nombreLocal = Console.ReadLine();
                    Console.Write("Ingrese el nombre del equipo visitante: ");
                    string nombreVisitante = Console.ReadLine();
                    Console.Write($"Ingrese los goles de {nombreLocal}: ");
                    int golesLocal = int.Parse(Console.ReadLine());
                    Console.Write($"Ingrese los goles de {nombreVisitante}: ");
                    int golesVisitante = int.Parse(Console.ReadLine());

                    miTorneo.JugarPartido(nombreLocal, nombreVisitante, golesLocal, golesVisitante);
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("- TABLA DE POSICIONES.");
                    miTorneo.VerTablaPosiciones();
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("- HISTORIAL DE PARTIDOS.");
                    miTorneo.VerHistorialPartidos();
                }
                else if (opcion == "5")
                {
                    Console.WriteLine("¡Nos vemos!");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, intente ingresando alguno de los números mostrados.");
                }

            }
        }
    }
}
