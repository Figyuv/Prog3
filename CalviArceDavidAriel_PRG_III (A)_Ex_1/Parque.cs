using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviArceDavidAriel_PRG_III__A__Ex_1
{
    internal class Parque
    {

        public string ParkName { get; set; }
        public Queue<Juego> Games { get; set; }
        
        public void nuevoJuego(string juegoNuevo, int capacidadJuego)
        {
            Games.Enqueue(new Juego()
            {
                GameName = juegoNuevo,
                maxCapacity = capacidadJuego,
            });
        }
    }
}
