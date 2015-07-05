using System;
using System.Reflection;

/**
* TODO ADD COMMENTS>>>
*/
namespace CustomAttributesApp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            AccountInfo NewUsr = new AccountInfo("Derp Derpson", 1101);
            NewUsr.Display();

            Console.ReadLine();
        }
    }
}
