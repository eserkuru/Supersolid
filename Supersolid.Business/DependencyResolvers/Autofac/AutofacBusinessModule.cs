using Autofac;
using Supersolid.Business.Abstract;
using Supersolid.Business.Concrete;
using Supersolid.DataAccess.Abstract;
using Supersolid.DataAccess.Concrete.EntityFramework.Dals;

namespace Supersolid.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SolutionManager>().As<ISolutionService>();
            builder.RegisterType<EfSolutionDal>().As<ISolutionDal>();

            builder.RegisterType<LayerManager>().As<ILayerService>();
            builder.RegisterType<EfLayerDal>().As<ILayerDal>();

            builder.RegisterType<ProjectManager>().As<IProjectService>();
            builder.RegisterType<EfProjectDal>().As<IProjectDal>();
        }
    }
}
