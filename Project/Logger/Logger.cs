using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GetirAPI.Logger
{
    public static class Log4Logger
    {
        private static readonly ILog _log;

        static Log4Logger()
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var configFileDirectory = Path.Combine(baseDirectory, "log4net.config");

            FileInfo configFileInfo = new FileInfo(configFileDirectory);
            log4net.Config.XmlConfigurator.ConfigureAndWatch(configFileInfo);

            _log = log4net.LogManager.GetLogger("log4netFileLogger");
        }

        public static void Info(string value)
        {
            _log.Info(value);
        }

        public static void Error(string value, Exception ex)
        {
            _log.Error(value, ex);
        }

        public static void Warning(string value)
        {
            _log.Warn(value);
        }
    }
}
