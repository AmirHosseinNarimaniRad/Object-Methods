using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods
{
    internal class Student
    {
        public string Name { get; set; }
        public string major { get; set; }
        public double gpa { get; set; }


        //a Constructor to create a student object
        public Student(string aName, string aMajor, double aGpa)
        {
            Name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
