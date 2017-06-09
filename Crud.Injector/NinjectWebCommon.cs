using System;
using Ninject;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject.Web.Common;
using System.Web;
using Crud.Injector.Container;

namespace Crud.Injector
{
    public class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();


        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                NinjectWebContainer.Container(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }
    }
}
