using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviDavid_Lambda
{
    internal class Tour
    {
        public string CodTo;
        public string NombreTo;
        public string RespTo;

        public Tour(string codTo, string nombreTo, string respTo)
        {
            CodTo = codTo;
            NombreTo = nombreTo;
            RespTo = respTo;
        }
    }
}
