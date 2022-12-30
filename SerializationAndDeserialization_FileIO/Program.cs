using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization_FileIO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome To  Serialization_FileIO problem***************");
            while(true)
            {
                Console.WriteLine("Please Click Below Options\n1.Serialization_FileIO");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("---------------------------------------------------------");
                        ApplicationDetails applicationDetails = new ApplicationDetails();
                        applicationDetails.Serialize();
                        break;
                }
            }

        }
       
    }
}

