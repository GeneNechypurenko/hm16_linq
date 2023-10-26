using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm16_task3
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string University { get; set; }

        public Student(string name, int age, string univ) 
        {
            Name = name;
            Age = age;
            University = univ;
        }

        public string this[string property]
        {
            get
            {
                if (property == "Name") { return Name; }
                else if (property == "Age") { return Age.ToString(); }
                else { return University; }
            }
        }
        public override string ToString()
        {
            return $"{Name} : {Age} : {University}";
        }
    }
}
