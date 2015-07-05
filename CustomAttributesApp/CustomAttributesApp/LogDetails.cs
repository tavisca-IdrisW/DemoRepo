using System;
using System.IO;
using System.Reflection;

namespace CustomAttributesApp
{
    class LogDetails
    {
        public static void LogToFile(Type ClassType, string MethodName)
        {
            try
            {
                string LogPath = @"\CustomAttributesAppt\Log.txt";
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

                string[] MethodNm = MethodName.Split(' ')[1].Split('(');
                //To Get the correct Method Name

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
