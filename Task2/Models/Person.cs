using System.Runtime.Serialization;

namespace OCP.Task2.Models
{
    [DataContract]
    public class Person
    {
        [DataMember(Order = 0)]
        public string Name { get; set;}

        [DataMember(Order = 1)]
        public string Job { get; set; }

        [DataMember(Order = 2)]
        public int Age { get; set; }
    }
}