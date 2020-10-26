using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("avi", 100);
            Student s2 = new Student("beni");
            Student s3 = new Student() { name = "sdfsdf" };

            Console.WriteLine(s3.GetStudentString());
        }
    }
}
