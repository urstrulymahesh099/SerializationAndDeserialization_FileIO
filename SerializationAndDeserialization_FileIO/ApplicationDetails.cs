using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization_FileIO
{
    public class ApplicationDetails
    {
        public string path = @"E:\Bridgelabz\SerializationAndDeserialization_FileIO\SerializationAndDeserialization_FileIO\TextFile1.txt";
        List<Serialization> application = new List<Serialization>()
        {
        };
        public void Serialize()
        {
            using (FileStream strem = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter bn = new BinaryFormatter();
                bn.Serialize(strem, application);
            }
            Console.WriteLine("Convert Object to Binary data");
            string binarytext = File.ReadAllText(path);
            Console.WriteLine(binarytext);
        }
    }
}
