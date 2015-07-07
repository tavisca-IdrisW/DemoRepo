using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingApp
{
    class MainClass
    {
        public static int Val1;
        public static int Val2;

        static void Main(string[] args)
        {
            MainClass.ValidateValue();

            var Obj1 = new SimpleClass(Val1, Val2);

            MainClass.ValidateValue();

            var Obj2 = new SimpleClass(Val1, Val2);

            var ObjSum = new SimpleClass();

            ObjSum = Obj1 + Obj2;

            Console.WriteLine(ObjSum);
            Console.WriteLine("Press Any Key to Exit....");
            Console.ReadLine();
        }
        private static void ValidateValue()
        {
            string Input1;
            string Input2;

            Console.Write("Enter Two Numeric values for obj1: ");
            Console.Write("Value 1: ");
            Input1 = Console.ReadLine();
            Console.Write("Value 2: ");
            Input2 = Console.ReadLine();


            if (!(Int32.TryParse(Input1, out Val1) && Int32.TryParse(Input2, out Val2)))
            {
                Console.WriteLine("Entered Value is Not an Number!!");
                Console.WriteLine("Please Enter Numeric Values!!");
                MainClass.ValidateValue();
            }
        }
    }
}
