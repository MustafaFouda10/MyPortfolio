using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public Address Address { get; set; }
    }
}
