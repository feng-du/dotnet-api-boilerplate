using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;
using System.Linq;

namespace MyProject
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MyProjectApplicationModule))]
    public class MyProjectWebApiModule : AbpModule
    {
        private void ConfigureSwaggerUi()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "MyProject.WebApi");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                   
                })
                .EnableSwaggerUi(c =>
                {
                    c.InjectJavaScript(Assembly.GetAssembly(typeof(MyProjectWebApiModule)), "MyProject.Api.Scripts.Swagger-Custom.js");
                    
                });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            ConfigureSwaggerUi();

            //Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
            //    .ForAll<IApplicationService>(typeof(MyProjectApplicationModule).Assembly, "app")
            //    .Build();
        }


    }
}
