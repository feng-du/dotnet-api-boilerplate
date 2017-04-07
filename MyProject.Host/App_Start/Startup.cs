using Castle.Facilities.Logging;
using Abp.Castle.Logging.Log4Net;
using Abp.WebApi.Configuration;
using Abp;
using Owin;

namespace MyProject.Host
{

    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var abpBootstrapper = AbpBootstrapper.Create<MyConsoleModule>();
            abpBootstrapper.Initialize();

            abpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig("log4net.config")
            );

            var httpConfig = abpBootstrapper.IocManager.Resolve<IAbpWebApiConfiguration>().HttpConfiguration;
            appBuilder.UseWebApi(httpConfig);
        }
    }
}
