using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static public void ShowBase(Object obj)
        {
            Type t = obj.GetType();
            Console.WriteLine(t.BaseType);
        }
        static List<Person> std = new List<Person>();
        static Person th1 = new Teacher(std);
        static void Main(string[] args)
        {
           

            Person st1 = new StudentWithAdvisor("Епи1", 2, th1);
            st1.Name = "Nursultan";
            st1.Surname = "Aldaiarov";
            st1.Age = 24;
            Person st2 = new StudentWithAdvisor("Епи2", 3, th1);
            st2.Name = "Evgeniy";
            st2.Surname = "Kiselev";
            st2.Age = 21;
            std.Add(st1);
            std.Add(st2);

            std.Add(th1);
            for (int i = 0; i < std.Count; i++)
            {
                if (std.ElementAt(i).GetType() == typeof(Teacher)) { std.Remove(std.ElementAt(i)); }
            };

            st1.print();
            Person st11 = (Person)st1.Clone();
            st11.print();
            st2.print();
            th1.print();



            ShowBase(new Student());

            Console.ReadKey();
        }

    }
}
