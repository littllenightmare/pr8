using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8
{
    class worker : man/*,*//* ICloneable, IComparable*/
    {
        string Name, Surname, Sex;

        //конструктор
        public string sex()
        {
            if (Sex == "M")
            {
                Sex = "пол мужской";
                return Sex;
            }
            else
            {
                Sex = "пол женский";
                return Sex;
            }
        }
     }
    class worker_dad:worker, man
    { 
     int Children;
    }
}
