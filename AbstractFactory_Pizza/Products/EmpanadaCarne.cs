using AbstractFactory_Pizza.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pizza.Products
{
    public class EmpanadaDeCarne : Empanada
    {
        public EmpanadaDeCarne()
        {
            _descripcion = "Empanada de carne";
        }
    }
}
