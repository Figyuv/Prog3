using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0218ListasPilasColas
{
    internal class Jugador
    {
        public string PlayerName{ get; set; }
        public int PlayerNumber { get; set; }

        public Jugador(string name, int number)
        {
            PlayerName = name;
            PlayerNumber = number;
        }
    }
}
