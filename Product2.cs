using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA1_M6_Persistencia
{
    public class Product2
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public Category[] Categories { get; set; }
    }
}
