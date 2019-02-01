using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ISerializer<T> where T : ISerializable
    {
        void Write(IEnumerable<T> dataSet, string dataPath);
        IEnumerable<T> Read(string dataPath);
    }
}
