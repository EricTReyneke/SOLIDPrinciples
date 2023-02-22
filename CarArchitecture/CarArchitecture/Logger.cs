using CarArchitecture.Interfaces;
using System.Text;
using CarArchitecture.Models;

namespace CarArchitecture
{
    public class Logger : ILogger
    {

        public Logger()
        {

        }

        private void LogVehicleExceptions(VehicleExceptions ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ex.Message);
            sb.AppendLine(ex.Severity.ToString());
            Console.Write(Environment.NewLine + sb.ToString());
        }

        public void LogFatal(Exception ex)
        {
            if (ex is VehicleExceptions)
            {
                LogVehicleExceptions((VehicleExceptions)ex);
            }
            else if (ex is ArgumentNullException)
            { }
        }

        public void LogInfo(string message)
        {
            throw new NotImplementedException();
        }
    }
}
