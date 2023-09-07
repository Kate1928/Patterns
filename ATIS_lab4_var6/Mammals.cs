using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class Mammals : Animals
    {
        public Mammals(Guid ID1, string condition1, string type1, string aviary1, string diet1, string therapy1) : base(ID1, condition1, type1, aviary1, diet1, therapy1) { }
    }
}
