using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods
{
    internal class Student
    {
        public string name;
        public string subject;
        public double GPA; 

        public Student(string aName, string aSubject, double aGPA)
        {
            name = aName;
            subject = aSubject;
            GPA = aGPA;

        }

        public bool HasHonours()
        {
            if (GPA >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
