using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    public class Student
    {
        int age;
        string name;
        const int MIN_AGE = 18;
        const int MAX_AGE = 99;

        public Student(string name, int age) 
        {
            this.name = name;
            this.age = age;            
        }
        public int Age 
        {  
            get { return age; }
            set 
            {
                if (value < MIN_AGE)
                {
                    age = MIN_AGE;
                } else if (value > MAX_AGE)
                { 
                    age = MAX_AGE;
                } else
                {
                    age = value;
                }
            }
        }

        public int? Mark;

        public string Info
        {
            get { return name + " " + age; }
        }
    }
}
