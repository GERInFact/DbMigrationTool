using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace AccessManager.AccessLayer.Interfaces
{
    public interface IDatabaseInformation
    {
        string ConnectionString { get; set; }
        AutoCreateOption Option { get; set; }
        UnitOfWork Work { get; set; }

        void ConnectToSqlDb(string connectionString);
        Task ConnectToSqlDbAsync(string connectionString);

        void ConnectToMySqlDb(string connectionString);
        Task ConnectToMySqlDbAsync(string connectionString);
    }
}
