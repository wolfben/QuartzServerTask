using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using QuartzServerTask.Utility.Log;

namespace QuartzServerTask.Jobs
{
    public abstract class BaseJob : IJob
    {
        public BaseJob()
        {
        }
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                Start();
            }
            catch (Exception ex)
            {
                LogUtility.ErrorFormat("任务：{0} 出现异常", ex, this.GetType().ToString());
            }
        }

        /// <summary>
        /// 子任务需要实现的方法
        /// </summary>
        public abstract void Start();
    }
}
