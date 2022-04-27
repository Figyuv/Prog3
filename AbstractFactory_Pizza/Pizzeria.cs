using AbstractFactory_Pizza.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pizza
{
    public abstract class Pizzeria
    {
        public abstract Pizza CrearPizza();
        public abstract Empanada CrearEmpanada();
    }
}
