using Autofac;
using Autofac.Integration.Mvc;
using TIMS.IMS.Data.Infrastructure;
using TIMS.IMS.Data.Repositories;
using TIMS.IMS.Services;
using TIMS.IMS.Web.Mappings;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Autofac.Integration.WebApi;
using System.Web.Http;

namespace TIMS.IMS.Web.App_Start
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacContainer();
            //Configure AutoMapper
            AutoMapperConfiguration.Configure();
        }

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly()); //Register MVC Controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();
            // builder.RegisterType<HardwareTypeService>().As<IHardwareTypeService>().InstancePerRequest();//Register any other components required by your code....

            // Repositories
            builder.RegisterAssemblyTypes(typeof(HardwareTypeRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
            // Services
            builder.RegisterAssemblyTypes(typeof(HardwareTypeService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); //Set the MVC DependencyResolver
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver
            
        }
    }
}