using Autofac;
using Autofac.Integration.Mvc;
using SkilltreeMvcHomework.Repositories;
using SkilltreeMvcHomework.Services;
using System.Web.Mvc;

namespace SkilltreeMvcHomework
{
    public class AutofacConfig
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //// Repositories
            builder.RegisterType<AccountingRepository>().As<IAccountingRepository>();

            //// Services
            builder.RegisterType<AccountingService>().As<IAccountingService>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}