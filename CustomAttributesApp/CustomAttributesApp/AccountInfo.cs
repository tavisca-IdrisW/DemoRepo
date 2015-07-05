using System;
using System.Reflection;

namespace CustomAttributesApp
{
    class AccountInfo
    {
        protected string AccName;
        protected int AccId;
        public AccountInfo(string AccName, int AccId)
        {
            this.AccName = AccName;
            this.AccId = AccId;
        }
        [DevInfo()]
        public int GetBalance()
        {

            LogDetails.LogToFile(this.GetType(), MethodInfo.GetCurrentMethod().ToString());
            return new Random().Next(100, 100000);
        }
        [DevInfo()]
        public void Display()
        {
            var Introspect = Assembly.GetExecutingAssembly();

            Console.WriteLine("Hello: {0}", AccName);
            Console.WriteLine("Account ID: {0}", AccId);
            Console.WriteLine("Your Balance is: {0}", GetBalance());

            LogDetails.LogToFile(this.GetType(), MethodInfo.GetCurrentMethod().ToString());
        }
    }
}
