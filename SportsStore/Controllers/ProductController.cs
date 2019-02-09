using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 2;
        /*
         * Constructor that take the IProductRepository repo 
         */
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        } 
        /*
         * This Method Get the Music Picture along with the Music Data and the Artist and the Genre Category
         * It is best if the ---Method -- is asynchronous becuase of performance and load time 
         * 
         */
        public ViewResult List(string category, int productPage = 1) => View(new ProductsListViewModel
        {
            //Returns a View with the Products  and Performs the Pagiantions Process of DataGrid 
            Products = repository.MusicProducts.Include(m => m.MusicPicture).Include(d => d.MusicData).Include(a => a.Artist).Include(g => g.GenreCategory).Include(a => a.Artist)
            .Where(p => category == null || p.GenreCategory.GenreName == category)
            .OrderBy(p => p.MusicID)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo 
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ? repository.MusicProducts.Count():repository.MusicProducts.Where(e => e.GenreCategory.GenreName == category).Count()
            },
            CurrentCategory = category
        });
    }
}