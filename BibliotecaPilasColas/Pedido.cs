using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPilasColas
{
    internal class Pedido
    {
        public int Telefono { get; set; }
        public List<string> Producto { get; set; }

        public Pedido(int telefono, List<string> products)
        {
            Telefono = telefono;
            Producto = products;
            
        }



    }
}
