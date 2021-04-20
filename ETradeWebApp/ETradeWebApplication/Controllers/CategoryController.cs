using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.OperationResults;
using Entities.Concrete;
using ETradeWebApplication.Api_Service;
using ETradeWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETradeWebApplication.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryApiService _categoryApiService;
        public CategoryController(CategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public async Task<IActionResult> Index()
        {
            
            var model = new CategoryListViewModel
            {
                Categories = await _categoryApiService.GetListAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Category category)
        {
            var authHeader = Request.Headers["Authorization"];
            await _categoryApiService.DeleteAsync(category, authHeader);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int categoryId)
        {
            var model = new CategoryListViewModel
            {
                Category = await _categoryApiService.GetByIdAsync(categoryId)
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            var authHeader = Request.Headers["Authorization"];
            await _categoryApiService.UpdateAsync(category, authHeader);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int categoryId)
        {
            var model = new CategoryListViewModel
            {
                Category = await _categoryApiService.GetByIdAsync(categoryId)
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Category category)
        {
            var authHeader = Request.Headers["Authorization"];
            await _categoryApiService.AddAsync(category, authHeader);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
