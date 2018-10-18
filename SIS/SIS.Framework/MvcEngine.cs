﻿using System;
using System.Reflection;
using SIS.WebServer;

namespace SIS.Framework
{
    public static class MvcEngine
    {
        public static void Run(Server server)
        {
            RegisterAssemblyName();
            RegisterControllerData();
            RegisterViewsData();
            RegisterModelsData();

            try
            {
                server.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void RegisterModelsData()
        {
            MvcContext.Get.ModelsFolder = "Models";
        }

        private static void RegisterViewsData()
        {
            MvcContext.Get.ViewsFolder = "Views";
        }

        private static void RegisterControllerData()
        {
            MvcContext.Get.ControllersFolder = "Controllers";
            MvcContext.Get.ControllerSuffix = "Controller";
        }

        private static void RegisterAssemblyName()
        {
            MvcContext.Get.AssemblyName = Assembly.GetEntryAssembly().GetName().Name;
        }
    }
}
