using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class Animals
    {
        //protected Guid ID = Guid.NewGuid();
        public Guid ID;
        public string condition;//-1 = умер, 0 = заболел, 1 = здоров
        public string type;
        public string aviary;// номер вольера
        public string diet;
        public string therapy;// изменение температуры, еды, инфекция
       

        public virtual void Function1() { }
        public Animals(Guid ID1, string condition1, string type1, string aviary1, string diet1, string therapy1)
        {
            ID = ID1;
            condition = condition1;
            type = type1;
            aviary = aviary1;
            diet = diet1;
            therapy = therapy1;
        }
    }
}
