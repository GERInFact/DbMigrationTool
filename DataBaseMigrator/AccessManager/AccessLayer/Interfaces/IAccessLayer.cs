using System.Collections.Generic;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace AccessManager.AccessLayer.Interfaces
{
    public interface IAccessLayer<T> where T: XPLiteObject, new()
    {
        void Create();
        IEnumerable<T> Read();
        void Update();
        void Delete(T data);
        Task CreateAsync();
        Task<IEnumerable<T>> ReadAsync();
        Task UpdateAsync();
        Task DeleteAsync(T data);

        void ConnectToDb();
        Task ConnectToDbAsync();

        void SetConnectionString(string connectionString);
    }
}
