using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExTspValueTypeVsRefType
{
    class MyClass //1
    {
        public int x;
    }
    struct MyStruct //2
    {
        public int x;
    }
    class ValueTypeVSRefType
    {
        static void inc(MyClass mc, MyStruct ms)
        {
            mc.x++;
            ms.x++;
        }

        static void Main(string[] args)
        {

            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.x = 9;
            myStruct.x = 9;
            System.Console.WriteLine("*** Before ***");
            System.Console.WriteLine("Class value is {0}", myClass.x);
            System.Console.WriteLine("Struct value is {0}", myStruct.x);
            inc(myClass, myStruct);
            System.Console.WriteLine("*** After ***");
            System.Console.WriteLine("Class value is {0}", myClass.x);
            System.Console.WriteLine("Struct value is {0}", myStruct.x);
            System.Console.ReadLine();
        }

    }
}