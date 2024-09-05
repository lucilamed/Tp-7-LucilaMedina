using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3TP7.Modelo
{
    internal class Clientes
    {
        private string nombre;
        private string direcciondenvio;
        private string correo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direcciondenvio { get => direcciondenvio; set => direcciondenvio = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
