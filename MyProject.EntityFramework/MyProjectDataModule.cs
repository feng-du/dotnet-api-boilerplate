using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using MyProject.EntityFramework;

namespace MyProject
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(MyProjectCoreModule))]
    public class MyProjectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<MyProjectDbContext>(null);
        }
    }
}
