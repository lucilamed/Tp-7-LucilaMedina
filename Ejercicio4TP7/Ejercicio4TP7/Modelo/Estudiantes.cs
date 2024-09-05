using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4TP7.Modelo
{
    internal class Estudiantes
    {
        private string nombre;
        private int matricula;
        private string año_cursado;


        public string Nombre { get => nombre; set => nombre = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public string Año_cursado { get => año_cursado; set => año_cursado = value; }
    }
}
