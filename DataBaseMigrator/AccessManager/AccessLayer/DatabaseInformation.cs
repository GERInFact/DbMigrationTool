using System.Data.SqlClient;
using System.Threading.Tasks;
using AccessManager.AccessLayer.Interfaces;
using AccessManager.Helper;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using MySql.Data.MySqlClient;

namespace AccessManager.AccessLayer
{
    public class DatabaseInformation : IDatabaseInformation
    {
        public DatabaseInformation(AutoCreateOption option)
        {
            this.ConnectionString = string.Empty;
            this.Option = option;
            this.Work = Factory.CreateWorkUnit();
        }

        public string ConnectionString { get; set; }
        public AutoCreateOption Option { get; set; }
        public UnitOfWork Work { get; set; }
        public void ConnectToSqlDb(string connectionString)
        {
            if (!this.IsConnectionAttemptValid(connectionString)) return;

            this.Work.Connect(XpoDefault.GetDataLayer(new SqlConnection(this.ConnectionString), this.Option));
        }

        public async Task ConnectToSqlDbAsync(string connectionString)
        {
            await Task.Run(() => this.ConnectToMySqlDb(connectionString));
        }

        public void ConnectToMySqlDb(string connectionString)
        {
            if (!this.IsConnectionAttemptValid(connectionString)) return;

            this.Work.Connect(XpoDefault.GetDataLayer(new MySqlConnection(this.ConnectionString), this.Option));
        }

        public async Task ConnectToMySqlDbAsync(string connectionString)
        {
            await Task.Run(() => this.ConnectToMySqlDb(connectionString));
        }

        private bool IsConnectionAttemptValid(string connectionString)
        {
            this.ConnectionString = connectionString;

            return !string.IsNullOrWhiteSpace(this.ConnectionString)
                && !this.Work.IsConnected;
        }
    }
}
