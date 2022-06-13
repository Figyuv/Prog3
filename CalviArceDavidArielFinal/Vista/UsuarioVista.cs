using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalviArceDavidArielFinal.Modelo;

namespace CalviArceDavidArielFinal.Vista
{
    public class UsuarioView
    {
        public void showUserDetails(int id, string name, List<String> conferencias)
        {
            Console.WriteLine($"Usuario:\nId: {id}\nNombre: {name}\nConferencias: {showConferences(conferencias)}");
        }
        public string showConferences(List<String> conferencias)
        {
            string result = "";
            foreach (var conferencia in conferencias)
            {
                result = result + conferencia + "\n";
            }
            return result;
        }
    }
}
