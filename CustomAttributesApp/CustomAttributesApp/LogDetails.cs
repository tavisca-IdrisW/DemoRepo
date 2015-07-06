using System;
using System.IO;
using System.Reflection;

namespace CustomAttributesApp
{
    /**
     * LogDetails Class will contain a static method to put data into the log file.
     */
    class LogDetails
    {
        /**
         * This is a generic (Can be used for any method which has a custom attribute of any
         * class.) method to write the Log to the log file.
         * 
         * For any method that we wich to track the usage of we just call this method inside it.
         * 
         * TODO: Look for a way without having to call this function explicitly.
         */
        public static void LogToFile(Type ClassType, string MethodName)
        {
            try
            {
                string LogPath = @".\Log.txt";
                FileStream LogFile;
                if (File.Exists(LogPath))
                {
                    LogFile = new FileStream(LogPath, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    LogFile = new FileStream(LogPath, FileMode.Create, FileAccess.Write);
                }
                StreamWriter LogStream = new StreamWriter(LogFile);
                DevInfo InfoObj;
                string LogTime ="";

                /**
                 * The GetCurrentMethod() of class MethodInfo returns 
                 * the Method name as so <returntype> <MethodName>().
                 * 
                 * That is what we get in the MethodName.
                 * 
                 * But we require only the <MethodName>, hence the need for the spliting.
                 */
                string[] MethodNm = MethodName.Split(' ')[1].Split('(');

                MethodInfo MethInfo = ClassType.GetMethod(MethodNm[0]);
                if (null != MethInfo)
                {
                    foreach (Attribute Attrib in MethInfo.GetCustomAttributes(true))
                    {
                        InfoObj = Attrib as DevInfo;
                        if (null != InfoObj)
                        {
                            LogTime = InfoObj.CurrentTime;
                        }
                    }
                }

                string LogString = "Method: " + MethodName + " of Class: " + ClassType.Name + " Accessed At: " + LogTime;

                LogStream.WriteLine(LogString);

                LogStream.Close();
                LogFile.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
