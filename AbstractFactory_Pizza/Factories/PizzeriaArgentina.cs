using AbstractFactory_Pizza.Abstract_Products;
using AbstractFactory_Pizza.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pizza.Factories
{
    public class PizzeriaArgentina : Pizzeria
    {
        public override Empanada CrearEmpanada()
        {
            return new EmpanadaDeCarne();
        }

        public override Pizza CrearPizza()
        {
            return new PizzaHawaiana();
        }
    }
}
