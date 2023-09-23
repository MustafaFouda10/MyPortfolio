using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Address : EntityBase
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string FlatNumber { get; set; }
    }
}
