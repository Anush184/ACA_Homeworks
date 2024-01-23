using FileProcessing.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessing
{
    class FileLogger : IFileLogger
    {
        private string _errorFile;

        public FileLogger()
        {
            if (!File.Exists(_errorFile))
            {
                _errorFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "error_log.txt");
            }

        }
       public void LogException(Exception ex)
        {
            
            try
            {
                using (StreamWriter logWriter = new StreamWriter(_errorFile, true))
                {
                    logWriter.WriteLine(DateTime.Now + " - " + ex.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
