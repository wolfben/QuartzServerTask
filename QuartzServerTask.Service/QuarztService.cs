using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf;
using Quartz;
using Quartz.Impl;
using log4net;
using QuartzServerTask.Utility.Log;

namespace QuartzServerTask.Service
{
    public class QuarztService : ServiceControl, ServiceSuspend
    {
        private readonly IScheduler sche;

        public QuarztService()
        {
            LogUtility.Init();
            sche = StdSchedulerFactory.GetDefaultScheduler();
        }

        public bool Start(HostControl hostControl)
        {
            sche.Start();
            LogUtility.Info("服务启动成功");
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            sche.Shutdown();
            LogUtility.Info("服务停止成功");
            return true;
        }

        public bool Continue(HostControl hostControl)
        {
            sche.ResumeAll();
            return true;
        }

        public bool Pause(HostControl hostControl)
        {
            sche.PauseAll();
            return true;
        }
    }
}
