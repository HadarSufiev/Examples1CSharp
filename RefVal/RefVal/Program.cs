using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVal
{
    /*
     * ValueType : basic type(int,float,char),enum,struct
     * ReferenceType: class, interface, delegate , arrays ... 
     */
    public enum CarType { MANUAL, AUTOMAT}; //ValueType
    class Car //ReferenceType
    {
        public string Company { get; set; }
        public CarType Type { get; set; }

        public override string ToString()
        {
            return "Car-->" + Company +"-->"+ Type+ "\n";
        }
    }
    struct Weel //ValueType
    {
        public string Place { get; set; }
        public override string ToString()
        {
            return "Weel-->" + Place + "\n";
        }
    }
    class Program
    {
        #region swapValuesByValue
        //by value for reference type, copy the pointers
        //through the pointers we change the values in the object
       
        static void swapValuesByValue(Car c1, Car c2)
        {
            Car tmp = new Car() { Company = c2.Company, Type = c2.Type };
            c2.Company  = c1.Company;
            c2.Type = c1.Type;
            c1.Company = tmp.Company;
            c1.Type = tmp.Type;
        }
        //by value for value type, copy the objects
        //change the values of the copied objects
        static void swapValuesByValue(Weel w1, Weel w2)
        {
            Weel tmp = new Weel() { Place = w2.Place };
            w2.Place = w1.Place;
            w1.Place = tmp.Place;
        }
        #endregion


        #region easySwapByValue
        //swap the copied pointers
        static void easySwapByValue(Car c1, Car c2)
        {
            Car tmp = c2;
            c2 = c1;
            c1 = tmp;
        }

        //swap the copied objects
        static void easySwapByValue(Weel w1, Weel w2)
        {
            Weel tmp = w2;
            w2 = w1;
            w1 = tmp;
        }
        #endregion


        #region easySwapByReference
        //swap the pointers themselves
        static void easySwapByReference(ref Weel w1, ref Weel w2)
        {
            Weel tmp = w2;
            w2 = w1;
            w1 = tmp;
        }

        //swap the objects themselves
        static void easySwapByReference(ref Car c1, ref Car c2)
        {
            Car tmp = c2;
            c2 = c1;
            c1 = tmp;
        }
        #endregion

        #region out
        //by reference with more options
        //myResult must be assign in the outFunc
        // myResult could not be assign before calling the outFunc function
        static void outFunc(out int myResult)
        {
            myResult = 5 * 2; //myResult must by assign
        }
        #endregion


        static void Main(string[] args)
        {
            #region ReferenceType vs ValueType = 

            //c1 is pointer. The "new" create the object
            Car c1 = new Car() { Company = "Toyota", Type = CarType.AUTOMAT};
            Car c2 = new Car() { Company = "Mazda" , Type = CarType .MANUAL};
            //w1 is object. The "new" initialize the fields to default values
            Weel w1 = new Weel() { Place = "left" };
            Weel w2 = new Weel() { Place = "right" };

          

            Console.WriteLine("ReferenceType vs ValueType...\n");

            Console.WriteLine("before:\nc1: " + c1+ " \nc2: "+c2);
            c1 = c2;
            c2.Company = "Volvo";
            Console.WriteLine("after:\nc1: " + c1 + " \nc2: " + c2);

            Console.WriteLine("before:\nw1: " + w1 + " \nw2: " + w2);
            w1 = w2;
            w2.Place = "Center";
            Console.WriteLine("after:\nw1: " + w1 + " \nw2: " + w2);
            #endregion

            #region ReferenceType vs ValueType swapByValue 

            Car c3 = new Car() { Company = "Toyota", Type = CarType.AUTOMAT };
            Car c4 = new Car() { Company = "Mazda", Type = CarType.MANUAL };
            //w1 is object. The "new" initialize the fields to default values
            Weel w3 = new Weel() { Place = "left" };
            Weel w4 = new Weel() { Place = "right" };

            Console.WriteLine("before Swapping........................\n");

            Console.WriteLine(" c3: " + c3 + " \nc4: " + c4);
            Console.WriteLine("\nw3: " + w3 + " \nw4: " + w4);

            Console.WriteLine("after Swapping....\n");
            //swapValuesByValue(c3, c4); //work!
            //swapValuesByValue(w3, w4); //dont work!

            //easySwapByValue(c3, c4); //dont work!
            //easySwapByValue(w3, w4);//dont work!

            easySwapByReference(ref c3, ref c4); //work!
            easySwapByReference(ref w3, ref w4);//work!
            
            Console.WriteLine("\nc3: " + c3 + " \nc4: " + c4);
            Console.WriteLine("\nw3: " + w3 + " \nw4: " + w4);
            #endregion

            #region out
            int myResult; // myResult could not be assign before calling the outFunc function
            outFunc(  out myResult);
            Console.WriteLine("myResult = " + myResult);
            #endregion
        }
    }
}
