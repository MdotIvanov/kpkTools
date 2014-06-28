using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        private static readonly ILog log =
    LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {

            BasicConfigurator.Configure();
            log.Debug("Debug msg");
            log.Error("Error msg");
        }
    }
}
