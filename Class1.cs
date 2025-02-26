using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13_2_karamov
{
    class Student
    {
        private string name;
        private string surname;
        private int bookNumber;
        private int age; //возраст студента
        private string group; //группа студента
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int BookNumber
        {
            get { return bookNumber; }
            set { bookNumber = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Group 
        {
            get { return group; }
            set { group = value; }
        }
    }
}
