using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    public class BasePerson // BasePerson class created
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void printName()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }

    public class Student : BasePerson // Student class was created by inheritance from BasePerson class
    {
        public int StudentID { get; set; }
        public void printStudentInfo()
        {
            Console.WriteLine($"{Name} {Surname} {StudentID}");
        }
    }

    public class Teacher : BasePerson // Teacher class was created by inheritance from BasePerson class
    {
        public int Salary { get; set; }
        public void printTeacherInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Salary}");
        }
    }
}
