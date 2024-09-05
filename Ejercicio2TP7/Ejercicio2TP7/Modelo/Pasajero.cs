using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2TP7.Modelo
{
    internal class Pasajero
    {
        private string nombre;
        private int numdpasajero;
        private string nacionalidad;

        
        public string Nombre { get => nombre; set => nombre = value; }
        public int Numdpasajero { get => numdpasajero; set => numdpasajero = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}
