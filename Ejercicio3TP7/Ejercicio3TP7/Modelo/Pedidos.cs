using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3TP7.Modelo
{
    internal class Pedidos
    {
        private string identificador;
        private string fechadepedido;
        private string cliente;
        private int preciototal;


        public string Identificador { get => identificador; set => identificador = value; }
        public string Fechadepedido { get => fechadepedido; set => fechadepedido = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public int Preciototal { get => preciototal; set => preciototal = value; }
    }
}
