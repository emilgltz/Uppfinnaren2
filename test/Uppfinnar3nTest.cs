using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Uppfinnar3n.Models;
using Xunit;

namespace Uppfinnar3n.Tests
{
    public class UppfinnarenTest
    {
        
        //testar om det går att skapa en instans av productRepository samt om den innehåller alla produkter
        [Fact]
        public void AddingProducts()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "test")
            .Options;

            //Act
            using (var _appDbContext = new AppDbContext(options))
            {
                ProductRepository productRepository = new ProductRepository(_appDbContext);
                var allProducts = productRepository.AllProducts;

                List<Product> _allProducts = new List<Product>();

                foreach (var product in allProducts)
                {
                    _allProducts.Add(product);
                }
                var expected = _allProducts.Count;
                var actual = allProducts.Count();

                //Assert
                Assert.NotEmpty(allProducts);
                Assert.Equal(expected, actual);
            }
        }

        //testar om det är möjligt att skapa en instans av CategoryRepository och om den innehåller alla kategorier
        [Fact]
        public void AddingCategories()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "test")
            .Options;

            List<Category> _categories = new List<Category>();

            //Act
            using (var _appDbContext = new AppDbContext(options))
            {
                CategoryRepository categoryRepository = new CategoryRepository(_appDbContext);
                var allCategoryProducts = categoryRepository.AllCategories;

                foreach (var category in allCategoryProducts)
                {
                    _categories.Add(category);
                }
                var expected = _categories.Count;

                var actual = allCategoryProducts.Count();

                //Assert
                Assert.NotEmpty(allCategoryProducts);
                Assert.Equal(expected, actual);

            }
        }

        
    }
}
