using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalviArceDavidArielFinal.Modelo;

namespace CalviArceDavidArielFinal.Vista
{
    public class ConferenciaView
    {
        public void showConfferenceDetails(int id, string name, DateTime inicio, DateTime final, int participantes)
        {
            Console.WriteLine($"Conferencia\nId: {id}\nNombre: {name}\nInicio: {inicio}\nFin: {final}\n Numero de participantes: {participantes}");
        }
        
    }
}

