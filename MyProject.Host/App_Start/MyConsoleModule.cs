using System.Reflection;
using System.Web.Http;
using Abp.Configuration.Startup;
using Abp.Modules;

namespace MyProject.Host
{
    [DependsOn(typeof(MyProjectWebApiModule), typeof(MyProjectDataModule))]
    public class MyConsoleModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration = new HttpConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().HttpConfiguration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
