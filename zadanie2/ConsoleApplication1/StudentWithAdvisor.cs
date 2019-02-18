using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class StudentWithAdvisor : Student
    {
        private Person teacher;

        public StudentWithAdvisor() { }

        public StudentWithAdvisor(String group, int kurs, Person th)
        {
            this.teacher = th;
            this.Group = group;
            this.Kurs = kurs;
        }
        public Person Teacher
        { get; set; }

        static List<StudentWithAdvisor> students = new List<StudentWithAdvisor>();

        static public StudentWithAdvisor random()
        {
            Random RandomNumber1 = new Random();
            StudentWithAdvisor st1 = new ConsoleApplication1.StudentWithAdvisor();
            st1.Name = "Nursultan";
            st1.Surname = "Aldaiarov";
            st1.Age = 24;
            students.Add(st1);

            StudentWithAdvisor st2 = new ConsoleApplication1.StudentWithAdvisor();
            st2.Name = "Evgeniy";
            st2.Surname = "Kiselev";
            st2.Age = 21;

            students.Add(st2);


            return students.ElementAt(RandomNumber1.Next(0, 2));
        }
        public override object Clone()
        {
            return new Student { Name = this.Name, Surname = this.Surname, Age = this.Age, Group = this.Group, Kurs = this.Kurs };
        }
        public override void print()
        {
            Console.WriteLine(this);
        }

        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            Student p = obj as Student;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (Name == p.Name) && (Surname == p.Surname) && (Age == p.Age);
        }
        public override string ToString()
        {
            string str = base.ToString() + "Учитель: " + teacher.Name + " " + teacher.Surname + ";" + "\n" + "Группа:" + Group + ";" + "\n" + "Курс:" + Kurs + ";" + "\n";
            return str;
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
