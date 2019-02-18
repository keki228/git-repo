using System;

namespace ConsoleApplication1
{
    class Person
    {
        private int age;
        private string name;
        private string surname;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0) value = 0; age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        virtual public void print()
        {
            Console.WriteLine(ToString());

        }
        public override string ToString()
        {
            string str = "Имя: " + name + ";" + "\n" + "Фамилия: " + surname + ";" + "\n" + "Возраст: " + age + ";" + "\n";
            return str;
        }
        virtual public object Clone()
        {
            return new Person { Name = this.Name, Surname = this.Surname, Age = this.Age };
        }

        
    }
}
