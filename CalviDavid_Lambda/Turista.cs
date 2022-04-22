using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviDavid_Lambda
{
    internal class Turista
    {
        public int CIT;
        public string NombreT;
        public string CodTo;
        public int CodP;

        public Turista(int cIT, string nombreT, string codTo, int codP)
        {
            CIT = cIT;
            NombreT = nombreT;
            CodTo = codTo;
            CodP = codP;
        }
    }
}
