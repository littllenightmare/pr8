using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr8
{
    class worker : man,ICloneable
    {
        string Name, Surname, Sex;

        public worker(string name, string surname, string sex)
        {
            Name = name; Surname = surname; Sex = sex;
        }
        public string info() 
        {
            string info = "Имя работника: " + Name + "; фамилия работника: " + Surname + "; пол работника: " + Sex;
            return info;
        }

        public object Clone()
        {
            worker w = new worker(Name, Surname, Sex);
            return w;
        }
        public int CompareTo( worker other)
        {
         if(other.Surname == Surname) return 1;
         else return 0;
        }
    }
    class worker_dad : worker, man, ICloneable
    {
        int Children; string Name, Surname, Sex;
        public worker_dad(string name, string surname, string sex, int child):base (name, surname, sex)
        {
            Children = child;
        }

        public string dad_info()
        {
            string info = "Имя работника: " + Name + "; фамилия работника: " + Surname + "; пол работника: " + Sex + "; количество детей: " + Children;
            return info;
        }

        public new object Clone()
        {
            worker_dad wd = new worker_dad(Name, Surname, Sex, Children);
            return wd;
        }  

    }
}
