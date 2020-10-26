using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RandomExample
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Student[] students = new Student[4];
            students[0] = new Student() { FName = "tamar" };
            students[1] = new Student() { FName = "odaya" };
            students[2] = new Student() { FName = "maya" };
            students[3] = new Student() { FName = "ayala" };

            foreach (Student stu in students)
            {
                stu.setRandomalProjectMark();
                Console.WriteLine(stu);
            }
            string strLName, strMark, strYear;
           
            foreach (Student stu in students)
            {
               
                try
                {
                    Console.WriteLine("Next: ");
                    Console.WriteLine("enter {0} Last Name", stu.FName);
                    strLName = Console.ReadLine();
                    stu.LName = strLName;
                    Console.WriteLine("enter {0} Mark", stu.FName);
                    strMark = Console.ReadLine();
                    stu.ProjectMark = int.Parse(strMark);
                    if (stu.ProjectMark >= 100)
                        stu.ProjectMark = 100;
                    Console.WriteLine("enter {0} year", stu.FName);
                    strYear = Console.ReadLine();
                    while(strYear.Length>1 || (strYear[0]!='a' && strYear[0] != 'b' && strYear[0] != 'c' && strYear[0] != 'd'))
                    {
                        Console.WriteLine("please enter 'a' or 'b' or 'c' or 'd'\n");
                        strYear = Console.ReadLine();
                     }

                    stu.Year = strYear[0];
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("ecpected a <number> for mark, set mark to zero\n");
                    stu.ProjectMark = 0;
                }
            }
            Console.WriteLine("press any key to continue...\n");
            Console.ReadKey();
            Console.WriteLine("---------------------------------------\n");
            foreach (Student stu in students)
            {
                if (stu.ProjectMark < 55)
                    stu.StudentState = Successful.Failed;
                else if(stu.ProjectMark >= 55 && stu.ProjectMark < 75)
                    stu.StudentState = Successful.Moderate;
                else if (stu.ProjectMark >=75 && stu.ProjectMark < 90)
                    stu.StudentState = Successful.Good;
                else
                    stu.StudentState = Successful.Excellent;

                Console.WriteLine(stu);
                switch (stu.StudentState)
                {
                    case Successful.Excellent:  
                    case Successful.Good:
                        Console.WriteLine("good luck!\n");
                        break;
                    case Successful.Moderate:
                        Console.WriteLine("you have to learn more to succeed\n");
                        break;
                    case Successful.Failed:
                        Console.WriteLine("sorry, you have to do again the project\n");
                        break;
                    default:
                        break;
                }

            }



            

        }
    }
}
