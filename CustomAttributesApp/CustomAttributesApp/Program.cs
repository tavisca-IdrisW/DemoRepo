using System;
using System.Reflection;

namespace CustomAttributesApp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            AccountInfo NewUsr = new AccountInfo("Derp Derpson", 1101);
            NewUsr.Display();

            /**
             * This loop is to display the info of the Custom Attributes of the METHODS of the AccountInfo Class. 
             * 
             * The above was displaying the attributes info applied above the whole class.
             * This is required to display the Method attribute info.
             * 
             * The outer loop is uses the MethodInfo class of System.Reflections.
             * 
             * TODO Try and reduce the two loops to one loop. Could not really optimize the code right now...
             * -IW
             */

            Console.ReadLine();
        }
    }
}