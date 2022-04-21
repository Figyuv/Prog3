using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041322_EjemplosLambda
{
    internal class Usuer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsOlder
        {
            get { return Age >= 21; }
        }
        public int Genre { get; set; }

        public string GenreForView
        {
            get { return Genre == 1 ? "Man" : "Woma"; }
        }
    }
}
