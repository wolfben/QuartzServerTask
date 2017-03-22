using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz.Job;
using Quartz;
using Common.Logging;
using QuartzServerTask.Utility.Log;

namespace QuartzServerTask.Jobs
{
    public class Job1 : BaseJob
    {
        public override void Start()
        {
            Console.WriteLine(DateTime.Now);

            LogUtility.Info(DateTime.Now);

            LogUtility.Error("error");

            throw new Exception("ex");
        }

    }
}
