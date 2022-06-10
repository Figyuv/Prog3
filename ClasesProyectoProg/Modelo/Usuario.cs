using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasesProyectoProg.Modelo
{
    public  class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }
        public List<Conferencia> Conferencias { get; set; }

        public Usuario()
        {

        }

        public Usuario(int id, string name, string rol, List<Conferencia> conferencias)
        {
            Id = id;
            Name = name;
            Rol = rol;
            Conferencias = conferencias;
        }
    }
}
