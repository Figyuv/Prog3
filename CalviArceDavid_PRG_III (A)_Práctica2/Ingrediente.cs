using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviArceDavid_PRG_III__A__Práctica2
{
    internal class Ingrediente
    {
        public int Id { get; set; }
        public string IngredientName { get; set; }

        public Ingrediente(int id, string name)
        {
            Id = id;
            IngredientName = name;
        }

    }
}
