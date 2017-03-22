using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf;
using Quartz;
using Quartz.Impl;

namespace QuartzServerTask.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.RunAsLocalSystem();
                x.Service<QuarztService>();

                x.SetDescription("QuartzDemo服务描述");
                x.SetDisplayName("QuartzDemo服务显示名称");
                x.SetServiceName("QuartzDemo服务名称");

                x.EnablePauseAndContinue();
            });
        }
    }
}
