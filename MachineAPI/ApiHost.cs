using MachineAPI.Config;
using Microsoft.Owin.Hosting;
using System;
using System.ServiceProcess;

namespace MachineAPI
{
    partial class ApiHost : ServiceBase
    {
        public ApiHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                WebApp.Start<HostStart>("http://+:" + Init.Port + "/");

                Logger.Save("Service started on port : " + Init.Port);

                Logger.Save();
            }
            catch (Exception err)
            {
                Logger.Save(err.ToString());

                Logger.Save();
            }
        }

        protected override void OnStop()
        {
            Logger.Save("Service stopped on port : " + Init.Port);

            Logger.Save();
        }
    }
}
