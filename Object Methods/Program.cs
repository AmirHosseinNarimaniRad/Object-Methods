using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student("Jim", "Business", 2.8);
            Student Student2 = new Student("Pam", "Art", 3.6);
            Student student3 = new Student("Oscar", "Accounting", 3.2);

            Console.WriteLine(Student1.HasHonors());
            Console.WriteLine(Student2.HasHonors());
            Console.WriteLine(student3.HasHonors());

            Console.ReadLine();
        }
    }
}
