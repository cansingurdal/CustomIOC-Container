using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Ninject;

namespace Ioc_Example.Models
{
    public static class NinjectHelper
    {
        public static IKernel Kernel { get; private set; }

        public static void Configure()
        {
            Kernel = new StandardKernel();
            Kernel.Bind<IBildirim>().To<MesajGonder>().InSingletonScope();
        }
    }
}