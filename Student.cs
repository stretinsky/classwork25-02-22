using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork25_02_2022
{
    class Student
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public string group { get; private set; }
        public Student(string name, string surname, string group)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
        }
    }
}
