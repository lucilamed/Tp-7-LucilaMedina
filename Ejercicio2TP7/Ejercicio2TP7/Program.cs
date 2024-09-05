using Ejercicio2TP7.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2TP7
{
    internal class Program
        /*2. Una compañía aérea desea implementar un sistema de gestión de vuelos. Los vuelos tienen un
número, una fecha de salida, un destino y un precio. Los pasajeros tienen un nombre, número
de pasaporte y nacionalidad. Se requiere un programa que permita gestionar los vuelos,
incluyendo la adición y eliminación de vuelos, así como la gestión de los pasajeros en cada
vuelo. Identifica los posibles objetos, atributos y métodos necesarios para implementar este
sistema.*/
    {
        static void Main(string[] args)
        {
            Vuelo vuelo1 = new Vuelo();
            Pasajero pasajero1 = new Pasajero();

            vuelo1.Numero = 18;
            vuelo1.Fdsalida = "16 de Octubre del 2024";
            vuelo1.Destino = "Dubai";
            vuelo1.Precio = 6000000;

            pasajero1.Nombre = "Medina Lucila";
            pasajero1.Numdpasajero = 24;
            pasajero1.Nacionalidad = "Argentino";

            Console.WriteLine("Numero de vuelo: " + vuelo1.Numero);
            Console.WriteLine("Fecha de salida: " + vuelo1.Fdsalida);
            Console.WriteLine("Destino: "+ vuelo1.Destino);
            Console.WriteLine("Precio del vuelo: " + vuelo1.Precio);
            Console.WriteLine();
            Console.WriteLine("Nombre del pasajero: " + pasajero1.Nombre);
            Console.WriteLine("NUmero de pasajero: " + pasajero1.Numdpasajero);
            Console.WriteLine("Nacionalidad: " + pasajero1.Nacionalidad);

            Console.ReadKey();
        }
    }
}
