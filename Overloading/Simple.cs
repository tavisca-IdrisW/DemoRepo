using System;

/// <summary>
/// Simple Class With two integer type attributes.
/// </summary>
namespace OverloadingApp
{
    class SimpleClass
    {
        private int cX;
        private int cY;

        public SimpleClass(int cX = 0, int cY = 0)
        {
            this.cX = cX;
            this.cY = cY;
        }

        /**
         * To Oveload the operator
         */
        public static SimpleClass operator +(SimpleClass Obj1, SimpleClass Obj2)
        {
            return new SimpleClass(Obj1.cX + Obj2.cX, Obj1.cY + Obj2.cY);
        }

        //To print the object in the WriteLine
        public override string ToString()
        {
            return "The Sum is: \n" + "X:" + cX + "\nY:" + cY;
        }
    }
}