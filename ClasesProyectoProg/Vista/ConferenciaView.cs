using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesProyectoProg.Modelo;

namespace ClasesProyectoProg.Vista
{
    public class ConferenciaView
    {
        public void showConfferenceDetails(int id, string name, DateTime inicio, DateTime final, List<Usuario> participantes)
        {
            Console.WriteLine($"Conferencia\nId: {id}\nNombre: {name}\nInicio: {inicio}\nFin: {final}\n Numero de participantes: {countOfUsers(participantes)}");
        }
        public string countOfUsers(List<Usuario> usuarios)
        {
            string count = usuarios.Count().ToString();
            return count;
        }
    }
}
