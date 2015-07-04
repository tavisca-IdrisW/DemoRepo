using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingApp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int Val1, Val2;
            String Str1, Str2;

            Console.Write("Enter Two Numeric values for obj1: ");
            Console.Write("Value 1: ");
            Str1 = Console.ReadLine();
            Console.Write("Value 2: ");
            Str2 = Console.ReadLine();

            Int32.TryParse(Str1, out Val1);
            Int32.TryParse(Str2, out Val2);
            
            var Obj1 = new SimpleClass(Val1, Val2);

            Console.Write("Enter Two Numeric values for obj1: ");
            Console.Write("Value 1: ");
            Str1 = Console.ReadLine();
            Console.Write("Value 2: ");
            Str2 = Console.ReadLine();

            Int32.TryParse(Str1, out Val1);
            Int32.TryParse(Str2, out Val2);

            var Obj2 = new SimpleClass(Val1, Val2);

            var ObjSum = new SimpleClass();

            ObjSum = Obj1 + Obj2;

            Console.WriteLine(ObjSum);
            Console.WriteLine("Press Any Key to Exit....");
            Console.ReadLine();
        }
    }
}
