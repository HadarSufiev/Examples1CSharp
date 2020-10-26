using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        public string name;
        int mark;//=55;
        //public Student(string name,int mark)
        //{
        //    this.name = name;
        //    this.mark = mark;
        //}
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name, int mark):this(name)
        {
            this.mark = mark;
        }
        public Student()
        {

        }


        public string GetStudentString()
        {
            return $"My name is {this.name} and my mark is {mark:f}";
        }
    }
}
