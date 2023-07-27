using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

using OCP.Task2.Interfaces;
using OCP.Task2.Models;

namespace OCP.Task2
{
    public class MySerializer : ISerializer
    {
        public string SerializeJSON<TEntity>(TEntity entity)
            where TEntity : Person
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TEntity));
                ser.WriteObject(ms, entity);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        public TEntity DeserializeJSON<TEntity>(string entity)
            where TEntity : Person
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TEntity));
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(entity)))
            {
                return ser.ReadObject(stream) as TEntity;
            }
        }

        public string SerializeXML<TEntity>(TEntity entity)
            where TEntity : Person
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(TEntity));
                ser.WriteObject(ms, entity);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        public TEntity DeserializeXML<TEntity>(string entity)
            where TEntity : Person
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(TEntity));
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(entity)))
            {
                return ser.ReadObject(stream) as TEntity;
            }
        }
    }
}