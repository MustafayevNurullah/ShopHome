using Microsoft.AspNetCore.Mvc;
using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using ShopHome.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Controllers
{
    public class HomeController:Controller
    {
        private ICategoryRepository categoryRepository;
        private IProductRepository productRepository;
        private ISubCategoryRepository subcategoryRepository;
        private ISlidersRepository slidersRepository;
        public HomeController(ISlidersRepository slidersRepository, ICategoryRepository categoryRepository, IProductRepository productRepository, ISubCategoryRepository subcategoryRepository)
        {
            this.slidersRepository = slidersRepository;
            this.categoryRepository = categoryRepository;
            this.productRepository = productRepository;
            this.subcategoryRepository = subcategoryRepository;
        }
        
        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            var slider = slidersRepository.AllSliders();
            var Category = categoryRepository.AllCategory();
            productViewModel.sliders = slider;
            productViewModel.categories = Category;
            return View(productViewModel);
        }
    }
}
