[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Crud.Injector.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Crud.Injector.NinjectWebCommon), "Stop")]

