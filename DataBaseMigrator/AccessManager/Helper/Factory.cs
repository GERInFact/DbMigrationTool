using AccessManager.AccessLayer;
using AccessManager.AccessLayer.Interfaces;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Models;

namespace AccessManager.Helper
{
    public static class Factory
    {

        private static UnitOfWork _session;

        public static UnitOfWork CreateWorkUnit(IDataLayer dataLayer)
        {
            return _session  ?? (_session = new UnitOfWork(dataLayer));
        }

        public static UnitOfWork GetWorkUnit()
        {
            return _session ?? (_session = new UnitOfWork());
        }

        public static IDatabaseInformation CreateDefaultDatabaseInformation()
        {
            return new DatabaseInformation(AutoCreateOption.DatabaseAndSchema);
        }

        public static brandkuerzel CreateBrand(Session session)
        {
            if (session == null)
                session = GetWorkUnit();

            return new brandkuerzel(session);
        }

        public static brandkuerzel CreateBrand(Session session, brandkuerzel brandkuerzel)
        {
            if (session != null && brandkuerzel != null)
                return new brandkuerzel(session)
                    {BrandId = brandkuerzel.BrandId, Brand = brandkuerzel.Brand, Kuerzel = brandkuerzel.Kuerzel};


            session = GetWorkUnit();
            return new brandkuerzel(session);


        }

        public static ISerializer<T> CreateDefaultSerializer<T>()
        {
            return new CustomXmlSerializer<T>();
        }
    }
}
