using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Core.Models
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public string Link { get; set; }

    }
}
