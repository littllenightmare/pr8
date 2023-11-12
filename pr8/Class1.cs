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
        /// <summary>
        /// Конструктор класса работик
        /// </summary>
        /// <param name="name">его имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="sex">пол</param>
        public worker(string name, string surname, string sex)
        {
            Name = name; Surname = surname; Sex = sex;
        }
        /// <summary>
        /// Метод вывода строки информации
        /// </summary>
        /// <returns>строку с информацией</returns>
        public string info() 
        {
            string info = "Имя работника: " + Name + "; фамилия работника: " + Surname + "; пол работника: " + Sex;
            return info;
        }
        /// <summary>
        /// Метод клонирования
        /// </summary>
        /// <returns>склонированный объект</returns>
        public object Clone()
        {
            worker w = new worker(Name, Surname, Sex);
            return w;
        }
        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="other">второй работник, с которым сравнивают</param>
        /// <returns>1 или 0</returns>
        public int CompareTo( worker other)
        {
         if(other.Surname == Surname) return 1;
         else return 0;
        }
    }
    class worker_dad : worker, man, ICloneable
    {
        int Children; string Name, Surname, Sex;
        /// <summary>
        /// конструктор класса работник отец
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="sex">пол</param>
        /// <param name="child">дети</param>
        public worker_dad(string name, string surname, string sex, int child):base (name, surname, sex)
        {
            Children = child; Name = name; Surname = surname; Sex = sex;
        }
        /// <summary>
        /// метод вывода строки информации
        /// </summary>
        /// <returns>строку с информацией</returns>
        public string dad_info()
        {
            string info = "Имя работника: " + Name + "; фамилия работника: " + Surname + "; пол работника: " + Sex + "; количество детей: " + Children;
            return info;
        }
        /// <summary>
        /// метод клонирования объекта
        /// </summary>
        /// <returns>клонированный объект</returns>
        public new object Clone()
        {
            worker_dad wd = new worker_dad(Name, Surname, Sex, Children);
            return wd;
        }  

    }
}
