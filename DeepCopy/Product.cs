using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, string> dic { get; set; }
    }
}
