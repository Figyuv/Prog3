using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesProyectoProg.Modelo
{
    public class Conferencia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public List<Usuario> Asistentes { get; set; }

        public Conferencia()
        {

        }

        public Conferencia(int id, string name, DateTime inicio, DateTime final, List<Usuario> asistentes)
        {
            Id = id;
            Name = name;
            Inicio = inicio;
            Final = final;
            Asistentes = asistentes;
        }
    }
}
