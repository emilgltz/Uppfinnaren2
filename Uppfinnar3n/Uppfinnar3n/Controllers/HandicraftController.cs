
using Microsoft.AspNetCore.Mvc;
using Uppfinnar3n.Models;
using Uppfinnar3n.ViewModels;

namespace Uppfinnar3n.Controllers
{
   
    public class ProductController : Controller
    {
        
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

       
        public ViewResult List()
        {
           
            ProductListViewModel productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.AllProducts;

           
            return View(productListViewModel);
        }


        public ViewResult Contact()
        {
           
            return View();
        }


        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public IActionResult WoodFigure()
        {
            var woodFigureViewModel = new WoodFigureViewModel();
            woodFigureViewModel.WoodFigure = _productRepository.WoodFigure;

            return View(woodFigureViewModel);
        }

        public IActionResult Painting()
        {
            var paintingViewModel = new PaintingViewModel();
            paintingViewModel.Painting = _productRepository.Painting;

            return View(paintingViewModel);
        }
        public IActionResult KitchenTools()
        {
            var kitchenToolsViewModel = new KitchenToolsViewModel();
            kitchenToolsViewModel.KitchenTools = _productRepository.KitchenTools;

            return View(kitchenToolsViewModel);
        }

        public IActionResult Furniture()
        {
            var furnitureViewModel = new FurnitureViewModel();
            furnitureViewModel.Furniture = _productRepository.Furniture;

            return View(furnitureViewModel);
        }

        public IActionResult Tools()
        {
            var toolsViewModel = new ToolsViewModel();
            toolsViewModel.Tools = _productRepository.Tools;

            return View(toolsViewModel);
        }
    }
}
