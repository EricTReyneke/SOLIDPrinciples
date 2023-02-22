using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarArchitecture.Interfaces
{
    public interface ILogger
    {
        void LogFatal(Exception ex);

        void LogInfo(string message);
    }
}
