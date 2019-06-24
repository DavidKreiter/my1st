using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class WriteLogsForStatistics
    {
        public static int i;
        private static StreamWriter log;

        public static void WriteLog(string strLog)
        {
            log = getStreamWriter();
            log.WriteLine(strLog);
            log.Close();
        }
        public static StreamWriter getStreamWriter()
        {
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;

            string logFilePath = "C:\\Logs\\";
            logFilePath = logFilePath + "Log-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";


            logFileInfo = new FileInfo(logFilePath);

            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }

            return  new StreamWriter(fileStream);

        }
    }
}
