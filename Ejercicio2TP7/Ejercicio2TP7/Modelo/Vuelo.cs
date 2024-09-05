using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2TP7.Modelo
{
    internal class Vuelo
    {
        private int numero;
        private string fdsalida;
        private string destino;
        private double precio;

        

        public int Numero { get => numero; set => numero = value; }
        public string Fdsalida { get => fdsalida; set => fdsalida = value; }
        public string Destino { get => destino; set => destino = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
