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
            GestorTorneo MiTorneo = new GestorTorneo();
            Console.Write("Ingrese el nombre del Equipo:");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la ciudad del Equipo:");
            string ciudad = Console.ReadLine();

            //ejemplo, luego lo borro
            Equipo Chelsea = new Equipo ("Chelsea", 86, 23, 5, "Londres");

        }
    }
}
