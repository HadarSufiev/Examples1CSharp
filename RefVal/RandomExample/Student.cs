using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExample
{
    class Student
    {
        static Random rnd;
        static int numberOfStudents;
        public string LName { get; set; }
        public string FName { get; set; }
        public string Id { get; set; }
        public int ProjectMark { get; set; }
        public char Year { get; set; }
        public Successful StudentState { get; set; }
        #region
        static Student(){ numberOfStudents = 0; rnd = new Random(); }
        public Student() { numberOfStudents++;   }
        ~Student() { numberOfStudents--; }
        #endregion
       /// <summary>
       /// The function set the project mark randomaly
       /// </summary>
        public void setRandomalProjectMark()
        {  
            ProjectMark = rnd.Next(0, 100);   
        }

        public override string ToString()
        {
            return "Student: " + FName + " " + LName + ", Mark: " + ProjectMark + "\n";
        }
    }
}
