using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Teacher : Person
    {
        private List<Person> students;

        public Teacher()
        { }
        public Teacher(List<Person> list)
        {
            Name = random().Name;
            Surname = random().Surname;
            Age = random().Age;
            students = list;
        }
        public override void print()
        {
            Console.WriteLine(this);
        }
        static public Teacher random()
        {
            List<Teacher> teachers = new List<Teacher>();
            Teacher th1 = new ConsoleApplication1.Teacher();
            th1.Name = "Irina";
            th1.Surname = "Vladimirovna";
            th1.Age = 30;
            teachers.Add(th1);

            Teacher th2 = new ConsoleApplication1.Teacher();
            th2.Name = "Vladimir";
            th2.Surname = "Sychev";
            th2.Age = 45;
            teachers.Add(th2);

            Random RandomNumber1 = new Random();
            return teachers.ElementAt(RandomNumber1.Next(0, 2));
        }
        public override string ToString()
        {
            string str = base.ToString() + "Студенты: " + "\n";

            foreach (Student s in students)
            {
                str += "\n" + s.Name + " " + s.Surname;
            };

            return str;
        }
        public override object Clone()
        {
            return new Teacher { Name = this.Name, Surname = this.Surname, Age = this.Age, students = this.students };
        }
        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            Teacher p = obj as Teacher;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (Name == p.Name) && (Surname == p.Surname) && (Age == p.Age);
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
