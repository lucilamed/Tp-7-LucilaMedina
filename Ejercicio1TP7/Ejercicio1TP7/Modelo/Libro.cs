using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1TP7.Modelo
{
    internal class Libro
    {
 
        private bool dispon { get; set; }

        private string nombre;
        private string autor;
        private int codigo;
        private string editorial;

        
        public double precio { get; set; }

        public bool Dispon { get => dispon; set => dispon = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Editorial { get => editorial; set => editorial = value; }
    }
}
//get: obtner el valor
// set: asignar y darle un valor
