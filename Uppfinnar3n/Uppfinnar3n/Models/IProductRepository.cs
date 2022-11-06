using System.Collections.Generic;

namespace Uppfinnar3n.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> WoodFigure { get; }
        IEnumerable<Product> Painting { get; }
        IEnumerable<Product> KitchenTools { get; }
        IEnumerable<Product> Furniture { get; }
        IEnumerable<Product> Tools { get; }
        Product GetProductById(int productId);
    }
}
