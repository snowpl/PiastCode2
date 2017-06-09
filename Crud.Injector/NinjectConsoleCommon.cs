using Crud.Injector.Container;
using Ninject;

namespace Crud.Injector
{
    public class NinjectConsoleCommon
    {
        public static IKernel Instance()
        {
            var kernel = new StandardKernel();
            try
            {
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
