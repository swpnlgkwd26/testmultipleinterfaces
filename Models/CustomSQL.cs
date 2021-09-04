using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMultipleInterfaces.Models
{
    public class CustomSQL : ICustomInterface
    {
        public string GetData()
        {
            return "SQL Hello World";
        }
    }
}
