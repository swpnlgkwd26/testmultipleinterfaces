using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMultipleInterfaces.Models
{
    public class CustomXML : ICustomInterface
    {
        public string GetData()
        {
            return "Hello World XML";
        }
    }
}
