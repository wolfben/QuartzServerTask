using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuartzServerTask.Utility.Log
{
    public class LogUtility
    {
        static readonly ILog infoLog = LogManager.GetLogger("info");
        static readonly ILog erroLog = LogManager.GetLogger("error");

        public static void Init()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void Info(object message)
        {
            infoLog.Info(message);
        }

        public static void Info(object message, Exception ex)
        {
            infoLog.Info(message, ex);
        }

        public static void InfoFormat(string format, params object[] args)
        {
            infoLog.InfoFormat(format, args);
        }

        public static void InfoFormat(string format, Exception ex, params object[] args)
        {
            format = string.Format(format, args);
            infoLog.Info(format, ex);
        }

        public static void Error(object message)
        {
            erroLog.Error(message);
        }

        public static void Error(object message, Exception ex)
        {
            erroLog.Error(message, ex);
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            erroLog.ErrorFormat(format, args);
        }

        public static void ErrorFormat(string format,Exception ex,params object[] args)
        {
            format = string.Format(format, args);
            erroLog.Error(format, ex);
        }
    }
}
