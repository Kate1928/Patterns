using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class OpenAviary : Aviary
    {
        public OpenAviary(string ID1, string statusDes1, string statusClean1, string Temperature1) : base(ID1, statusDes1, statusClean1, Temperature1, "") {}
    }
}
