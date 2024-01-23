using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessing.Interface
{
    public interface IFileLogger
    {
        void LogException(Exception ex);
    }
}
