using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4TP7.Modelo
{
    internal class Curso
    {
        private int codigo;
        private string nombre;
        private string profesor;
        private string materia;


        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Profesor { get => profesor; set => profesor = value; }
        public string Materia { get => materia; set => materia = value; }
    }
}
