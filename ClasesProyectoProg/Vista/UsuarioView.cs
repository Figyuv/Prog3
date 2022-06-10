using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesProyectoProg.Modelo;

namespace ClasesProyectoProg.Vista
{
    public class UsuarioView
    {
        public void showUserDetails(int id, string name, string rol, List<Conferencia> conferencias)
        {
            Console.WriteLine($"Usuario:\nId: {id}\nNombre: {name}\nRol: {rol}\nConferencias: {showConferences(conferencias)}");
        }
        public string showConferences(List<Conferencia> conferencias)
        {
            string result = "";
            foreach (Conferencia conferencia in conferencias)
            {
                result = result + conferencia.Name + "\n";
            }
            return result;
        }
    }
}
