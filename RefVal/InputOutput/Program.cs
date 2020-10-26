using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Id = 111111111, Name = "Sason", PerGender = Gender.Female };
            Console.WriteLine("Person p1--> {0}", p1);

            char choise = 'c';  //continue..

            List<Person> persons = new List<Person>();
            int ind = 0;
            int iId;
            string iName,strGender;
            Gender iPerGender;

            while(choise == 'c')
            {
                ind++;
                try
                {
                    Console.WriteLine("enter Id,Name ane gender of person " + ind + "\n");

                    int.TryParse(Console.ReadLine(), out iId);
                    iName = Console.ReadLine();
                    strGender = Console.ReadLine();
                    iPerGender = (Gender)Enum.Parse(typeof(Gender), strGender);

                    persons.Add(new Person() { Id = iId, Name = iName, PerGender = iPerGender });

                }
                catch (Exception)
                {
                    Console.WriteLine("error\n");
                    Console.Beep();
                }
               
                Console.WriteLine("Press c to continue and other letten to stop\n");
                choise = Console.ReadLine()[0];
            }

            foreach(Person p in persons)
            {
                Console.WriteLine(p +"\n");
            }

        }
    }
}
