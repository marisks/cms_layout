using CmsLayout.Models.Pages;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace CmsLayout.Business
{
    [ModuleDependency(typeof(ServiceContainerInitialization))]
    [InitializableModule]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(ConfigureContainer);
        }

        private static void ConfigureContainer(ConfigurationExpression container)
        {
            container.AddRegistry<StructureMapRegistry>();
        }

        public void Initialize(InitializationEngine context) { }

        public void Uninitialize(InitializationEngine context) { }

        public void Preload(string[] parameters) { }
    }

    internal class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            For<LayoutModel>()
                .HybridHttpOrThreadLocalScoped()
                .Use<LayoutModel>();
        }
    }
}
