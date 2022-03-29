using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviArceDavidAriel_ArbolDesiciones
{
    internal class Nodo
    {
        public string element;
        public int number;
        public Nodo left;
        public Nodo right;
        public Nodo(string _elemento, int _numero)
        {
            element = _elemento;
            left = null;
            right = null;
            number = _numero;
        }
    }
}
