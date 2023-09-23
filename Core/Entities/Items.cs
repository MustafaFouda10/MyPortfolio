using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Items : EntityBase
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
    }
}
