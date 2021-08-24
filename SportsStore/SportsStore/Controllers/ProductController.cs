using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using SportsStore.Views;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository repository;
        public int PagrSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(int productPage = 1)
        {
            return View(new ProductListViewModel
            {
                Poducts = repository.Products
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PagrSize)
                .Take(PagrSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PagrSize,
                    TotalItems = repository.Products.Count()
                }
            });
        }
    }
}