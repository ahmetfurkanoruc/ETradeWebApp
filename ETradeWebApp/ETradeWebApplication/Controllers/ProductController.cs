using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using ETradeWebApplication.Api_Service;
using ETradeWebApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETradeWebApplication.Controllers
{
    public class ProductController : Controller
    {
        private ProductApiService _productApiService;
        public ProductController(ProductApiService productApiService)
        {
            _productApiService = productApiService;
        }

        public async Task<IActionResult> Index(int categoryId)
        {
            var model = new ProductListViewModel
            {
                Products = categoryId > 0 ? await _productApiService.GetByCategoryIdAsync(categoryId) : await _productApiService.GetProductsAsync()
            };
            return View(model);
        }

        public async Task<IActionResult> Detail(int productId)
        {
            var model = new ProductListViewModel
            {
                Product = await _productApiService.GetByIdAsync(productId)
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            var authHeader = Request.Headers["Authorization"];
            await _productApiService.AddAsync(product, authHeader);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            var authHeader = Request.Headers["Authorization"];
            await _productApiService.UpdateAsync(product, authHeader);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int productId)
        {
            var model = new ProductListViewModel
            {
                Product = await _productApiService.GetByIdAsync(productId)
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Product product)
        {
            var authHeader = Request.Headers["Authorization"];
            await _productApiService.DeleteAsync(product, authHeader);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int productId)
        {
            var model = new ProductListViewModel
            {
                Product = await _productApiService.GetByIdAsync(productId)
            };
            return View(model);
        }
    }
}
