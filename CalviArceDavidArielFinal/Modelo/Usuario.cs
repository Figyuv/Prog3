using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalviArceDavidArielFinal.Modelo
{
    [Serializable]
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<String> Conferencias { get; set; }

        public Usuario()
        {

        }
        public Usuario(int id, string name, string rol, List<String> conferencias)
        {
            Id = id;
            Name = name;
            Conferencias = conferencias;
        }
    }
}
