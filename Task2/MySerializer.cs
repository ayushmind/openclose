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
    private TEntity Deserialize<TEntity>(string entity, DataContractSerializer serializer)
    {
        using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(entity)))
        {
            return (TEntity)serializer.ReadObject(stream);
        }
    }

    private string Serialize<TEntity>(TEntity entity, DataContractSerializer serializer)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            serializer.WriteObject(ms, entity);
            return Encoding.UTF8.GetString(ms.ToArray());
        }
    }

    public string SerializeJSON<TEntity>(TEntity entity)
    {
        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TEntity));
        return Serialize(entity, jsonSerializer);
    }

    public TEntity DeserializeJSON<TEntity>(string entity)
    {
        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TEntity));
        return Deserialize<TEntity>(entity, jsonSerializer);
    }

    public string SerializeXML<TEntity>(TEntity entity)
    {
        DataContractSerializer xmlSerializer = new DataContractSerializer(typeof(TEntity));
        return Serialize(entity, xmlSerializer);
    }

    public TEntity DeserializeXML<TEntity>(string entity)
    {
        DataContractSerializer xmlSerializer = new DataContractSerializer(typeof(TEntity));
        return Deserialize<TEntity>(entity, xmlSerializer);
    }
}

}
