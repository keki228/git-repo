namespace ConsoleApplication1
{
    class Student : Person
    {
        private string group;
        private int kurs;

        public Student() { }
        public Student( string str, int k)
        {
            group = str;
            kurs = k;
        }

        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }
        public int Kurs
        {
            get
            {
                return kurs;
            }
            set
            {
                kurs = value;
            }
        }

    }
}
