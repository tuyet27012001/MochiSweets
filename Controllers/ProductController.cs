using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MochiSweets.Models;
using MochiSweets.Services;

namespace MochiSweets.Controllers
{
    public class ProductController : Controller
    {
        private AdminService adminService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger ,AdminService adminService)
        {
             this.adminService = adminService;
            _logger = logger;
        }

        [HttpGet("/Product/ProductList")]
        public IActionResult ProductList(string category, string search, int page)
        {
            if (page == 0)
            {
                page = 1;
            }
            int limit = 9;
            int num = adminService.GetListProductSearch(category, search).total;
            ViewBag.total = Math.Ceiling((double)num / limit);
            ViewBag.listProduct = adminService.GetListProductSearch(category, search, limit, page);
            ViewBag.search = search;
            ViewBag.select = category;
            ViewBag.listImage = adminService.GetListImage();
            ViewBag.listCategory = adminService.GetListCategory();

            ViewBag.previousPage = page - 1;
            ViewBag.page = page;
            ViewBag.nextPage = page + 1;
            return View();
        }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

