using OCP.Task2.Models;

namespace OCP.Task2.Interfaces
{
    public interface ISerializer
    {
        string SerializeJSON<TEntity>(TEntity entity) where TEntity : Person;

        TEntity DeserializeJSON<TEntity>(string entity) where TEntity : Person;

        string SerializeXML<TEntity>(TEntity entity) where TEntity : Person;

        TEntity DeserializeXML<TEntity>(string entity) where TEntity : Person;
    }
}