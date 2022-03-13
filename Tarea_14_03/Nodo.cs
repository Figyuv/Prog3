using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_14_03
{
    class Nodo
    {
        public string elemento;
        public int numero;
        public Nodo izquierdo;
        public Nodo derecho;
        public Nodo(string _elemento, int _numero)
        {
            elemento = _elemento;
            izquierdo = null;
            derecho = null;
            numero = _numero;
        }

    }
}
