﻿using Ninject;
using Crud.IServices;
using Services;
using Crud.IServices.Command;
using Services.Command;
using IData.Interfaces.Command;
using Crud.Repositories;
using Crud.Repository;
using IData.Interfaces.Query;

namespace Crud.Injector.Container
{
    public class NinjectWebContainer
    {
        public static void Container(IKernel kernel)
        {
            kernel.Bind<ICustomerQueryService>().To<CustomerQueryService>().InThreadScope();
            kernel.Bind<ICustomerCommandService>().To<CustomerCommandService>().InThreadScope();
            kernel.Bind<ICustomerCommandRepository>().To<CustomerCommandRepository>().InThreadScope();
            kernel.Bind<ICustomerQueryRepository>().To<CustomerQueryRepository>().InThreadScope();
            kernel.Bind<IOutGoingCommandRepository>().To<OutgoingCommandRepository>().InThreadScope();
            kernel.Bind<IOutgoingQueryRepository>().To<IOutgoingQueryRepository>().InThreadScope();
            kernel.Bind<IOutgoingQueryServices>().To<IOutgoingQueryServices>().InThreadScope();
        }
    }
}
