using Microsoft.AspNetCore.Mvc;
using ShopHome.Repository.Abstract;
using ShopHome.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Controllers
{
    public class CategoryController:Controller
    {
        private ISubCategoryRepository subcategoryRepository;
        private IProductRepository productRepository;

        public CategoryController(IProductRepository productRepository, ISubCategoryRepository subcategoryRepository)
        {
            this.productRepository = productRepository;
            this.subcategoryRepository = subcategoryRepository;
        }

        public IActionResult Index(int Id)
        {
            ViewModel2 viewModel2 = new ViewModel2();
            viewModel2.subCategories= subcategoryRepository.AllSubCategories().Where(x=> x.CategoryId==Id).ToList();
            foreach (var item in viewModel2.subCategories)
            {

                viewModel2.products = productRepository.Products(item).ToList();
            }
            return View(viewModel2);
        }

        
    }
}
