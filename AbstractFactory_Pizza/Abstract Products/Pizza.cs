using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pizza.Abstract_Products
{
    public abstract class Pizza
    {
        protected string _descripcion;

        public object Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}
