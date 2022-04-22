using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviDavid_Lambda
{
    internal class Lugar
    {
        public string CodL;
        public string NombreL;
        public int CodP;

        public Lugar(string codL, string nombreL, int codP)
        {
            CodL = codL;
            NombreL = nombreL;
            CodP = codP;
        }
    }
}
