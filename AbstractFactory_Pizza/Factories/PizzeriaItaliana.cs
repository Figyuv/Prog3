using AbstractFactory_Pizza.Abstract_Products;
using AbstractFactory_Pizza.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pizza.Factories
{
    public class PizzeriaItaliana : Pizzeria
    {
        public override Empanada CrearEmpanada()
        {
            return new EmpanadaCapresse();
        }

        public override Pizza CrearPizza()
        {
            return new PizzaNapolitana();
        }

        public override Helado CrearHelado()
        {
            return new HeladoCrema();
        }
    }
}
