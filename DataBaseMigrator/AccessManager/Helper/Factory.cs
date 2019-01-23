using AccessManager.AccessLayer;
using AccessManager.AccessLayer.Interfaces;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Models;

namespace AccessManager.Helper
{
    public static class Factory
    {
        public static UnitOfWork CreateWorkUnit(IDataLayer dataLayer)
        {
            return new UnitOfWork(dataLayer);
        }

        public static UnitOfWork CreateWorkUnit()
        {
            return new UnitOfWork();
        }

        public static IDatabaseInformation CreateDefaultDatabaseInformation()
        {
            return new DatabaseInformation(AutoCreateOption.DatabaseAndSchema);
        }

        public static brandkuerzel CreateBrand(Session session)
        {
            if (session == null)
                session = CreateWorkUnit();

            return new brandkuerzel(session);
        }
    }
}
