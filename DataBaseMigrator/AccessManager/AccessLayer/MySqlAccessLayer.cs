using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccessManager.AccessLayer.Interfaces;
using AccessManager.Helper;
using DevExpress.Xpo;

namespace AccessManager.AccessLayer
{
    public class MySqlAccessLayer<T> : IAccessLayer<T> where T: XPLiteObject, new()
    {
        private readonly IDatabaseInformation _dbInfo;

        private string _connectionString;

        public MySqlAccessLayer(IDatabaseInformation dbInfo)
        {
            this._dbInfo = dbInfo ?? Factory.CreateDefaultDatabaseInformation();
            
        }
        public void Create()
        {
          Factory.CreateBrand(this._dbInfo.Work);

            this._dbInfo.Work.CommitChanges();
        }

        public IEnumerable<T> Read()
        {
            return this._dbInfo.Work.Query<T>();
        }

        public void Update()
        {
            this._dbInfo.Work.CommitChanges();
        }

        public void Delete(T data)
        {
            if (data == null)
                return;

            this._dbInfo.Work.Delete(data);
            this._dbInfo.Work.CommitChanges();
        }

        public async Task CreateAsync()
        {
            await Task.Run(() => this.Create());
        }

        public async Task<IEnumerable<T>> ReadAsync()
        {
            return await Task.Run(() => this.Read());
        }

        public async Task UpdateAsync()
        {
            await this._dbInfo.Work.CommitChangesAsync();
        }

        public async Task DeleteAsync(T data)
        {
            await Task.Run(() => this.Delete(data));
        }

        public void ConnectToDb()
        {
            this._dbInfo.ConnectToMySqlDb(this._connectionString);
        }

        public async Task ConnectToDbAsync()
        {
            await this._dbInfo.ConnectToMySqlDbAsync(this._connectionString);
        }

        public void SetConnectionString(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString)) return;

            this._connectionString = connectionString;
        }

        ~MySqlAccessLayer()
        {
            this._dbInfo.Work?.PurgeDeletedObjects();
            this._dbInfo.Work?.Dispose();
        }
    }
}
