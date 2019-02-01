using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    public class CustomXmlSerializer<T> : ISerializer<T> where T: ISerializable
    {
        public void Write(IEnumerable<T> dataSet, string dataPath)
        {
            if (!dataSet.Any()
             || string.IsNullOrWhiteSpace(dataPath)) return;

            using (var fs = new FileStream(dataPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                var serializer = new XmlSerializer(typeof(List<T>));

                serializer.Serialize(fs, dataSet);
            }
        }

        public IEnumerable<T> Read(string dataPath)
        {
            if(string.IsNullOrWhiteSpace(dataPath)) return new List<T>();

            using (var fs = File.OpenRead(dataPath))
            {
              var serializer = new XmlSerializer(typeof(List<T>));
              return serializer.Deserialize(fs) as List<T>;
            }
        }
    }
}
