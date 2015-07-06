using System;
using System.Reflection;

namespace CustomAttributesApp
{
    /**
     * Mainclass Will simply contain the Main Method.
     * 
     * An objetc of the AccountInfo Class will be created inside Main.
     * We will call the Display Method form here. 
     */
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
