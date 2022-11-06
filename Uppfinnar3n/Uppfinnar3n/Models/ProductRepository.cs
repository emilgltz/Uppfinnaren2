using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Uppfinnar3n.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;


        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }
       
        public IEnumerable<Product> WoodFigure
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(h => h.CategoryId == 1);
            }
        }

        public IEnumerable<Product> Painting
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(h => h.CategoryId == 2);
            }
        }

        public IEnumerable<Product> KitchenTools
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(h => h.CategoryId == 3);
            }
        }

        public IEnumerable<Product> Furniture
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(h => h.CategoryId == 4);
            }
        }

        public IEnumerable<Product> Tools
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(h => h.CategoryId == 5);
            }
        }

        
        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(h => h.ProductId == productId);
        }

    }
}
