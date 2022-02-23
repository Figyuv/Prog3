using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviArceDavid_PRG_III__A__Práctica2
{
    internal class Plato
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public double DishPrice { get; set; }

        List<Ingrediente> ingredientsList;
        public List<Ingrediente> IngredientsList { get { return ingredientsList; } }

        public Plato(int idD,string name, double price)
        {
            DishId = idD;
            DishName = name;
            DishPrice = price;
            ingredientsList = new List<Ingrediente>();
        }

        public Plato(int idD,string name, double price, List<Ingrediente> ingredientList)
        {
            DishId=idD;
            DishName = name;
            DishPrice = price;
            this.ingredientsList = ingredientList;
        }

        public void newDishes(List<Ingrediente> ingredientList)
        {
            ingredientsList = ingredientList;
        }
    }
}
