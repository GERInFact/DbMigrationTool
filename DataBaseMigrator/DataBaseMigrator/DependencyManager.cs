using AccessManager.AccessLayer;
using AccessManager.AccessLayer.Interfaces;
using DataBaseMigrator;
using DevExpress.Xpo.DB;
using Unity;
using Unity.Resolution;

namespace Models
{
    public static class DependencyManager
    {
        public static IUnityContainer GetConfiguredContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IDatabaseInformation, DatabaseInformation>();
            container.RegisterType<IAccessLayer<brandkuerzel>, MySqlAccessLayer<brandkuerzel>>();
            container.RegisterType<ISerializer<brandkuerzel>, CustomXmlSerializer<brandkuerzel>>();

            return container;
        }

    }
}
