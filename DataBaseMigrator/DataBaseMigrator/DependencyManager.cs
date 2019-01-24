using AccessManager.AccessLayer;
using AccessManager.AccessLayer.Interfaces;
using Models;
using Unity;

namespace DataBaseMigrator
{
    public static class DependencyManager
    {
        public static IUnityContainer GetConfiguredContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IDatabaseInformation, DatabaseInformation>();
            container.RegisterType<IAccessLayer<brandkuerzel>, SqlAccessLayer<brandkuerzel>>();
            container.RegisterType<ISerializer<brandkuerzel>, CustomXmlSerializer<brandkuerzel>>();

            return container;
        }

    }
}
