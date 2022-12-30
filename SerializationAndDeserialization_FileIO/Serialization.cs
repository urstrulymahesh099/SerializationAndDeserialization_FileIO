using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization_FileIO
{
    [Serializable]
    public class Serialization
    {
        public string ApplicationName { get; set; } = "Mahesh H";
        public int ApplicationID { get; set; } = 099;
    }
}