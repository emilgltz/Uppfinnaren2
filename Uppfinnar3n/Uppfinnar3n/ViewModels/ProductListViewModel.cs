using System.Collections.Generic;
using Uppfinnar3n.Models;

namespace Uppfinnar3n.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Product> CrochetItems { get; set; }

    }
}
