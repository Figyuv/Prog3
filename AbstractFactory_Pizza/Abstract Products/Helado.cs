using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pizza.Abstract_Products
{
    public abstract class Helado
    {
        protected string _descripcion;

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}
