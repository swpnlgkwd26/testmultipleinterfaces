using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMultipleInterfaces.Models
{
    public class CustomNoSQL : ICustomInterface
    {
        public string GetData()
        {
            return "Custom No SQL Data";
        }
    }
}
