using System.Runtime.Serialization;
using AccessManager.AccessLayer;
using AccessManager.AccessLayer.Interfaces;
using DevExpress.Xpo;
using Models;
using Unity;

namespace DataBaseMigrator
{
    public static class DependencyManager<T> where T : XPLiteObject, ISerializable, new()
    {
        public static IUnityContainer GetConfiguredContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IDatabaseInformation, DatabaseInformation>();
            container.RegisterType<IAccessLayer<T>, SqlAccessLayer<T>>();
            container.RegisterType<ISerializer<T>, CustomXmlSerializer<T>>();

            return container;
        }

    }
}
