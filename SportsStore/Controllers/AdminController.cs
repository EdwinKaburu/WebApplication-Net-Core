using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository repository;

        public AdminController (IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.MusicProducts);

        // public ViewResult Edit(int MusicID) => View(repository.MusicProducts.FirstOrDefault(p => p.MusicID == MusicID));

        // public ViewResult Edit(int MusicID) => View(repository.MusicProducts.Include(a => a.Artist).FirstOrDefault)
        public ViewResult Edit(int MusicID)
        {
            //MusicProduct Products = repository.MusicProducts.Include(m => m.MusicPicture).Include(d => d.MusicData).
            //    Include(a => a.Artist).Include(g => g.GenreCategory).FirstOrDefault(p => p.MusicID == MusicID);
            //MusicProduct Product = repository.MusicProducts.Include(a => a.Artist).Where(p => p.MusicID == MusicID);

            //   IQueryable<MusicProduct>  Products = repository.MusicProducts.Where(x => x.MusicID == MusicID).Include(a => a.Artist);
            //  return View(Products);

            return View(repository.MusicProducts.Include(a => a.Artist).Include(g => g.GenreCategory).FirstOrDefault(p => p.MusicID == MusicID));
        }
        [HttpPost]
        public IActionResult Edit(MusicProduct product)
        {
            if(ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.MusicName} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the data values
                return View(product);
            }
        }

        public ViewResult Create() => View("Edit", new MusicProduct());

        [HttpPost]
        public IActionResult Delete(int productID)
        {
            MusicProduct deleteProduct = repository.DeleteProduct(productID);
            if(deleteProduct != null)
            {
                TempData["message"] = $"{deleteProduct.MusicName} was deleted";
            }
            return RedirectToAction("Index");
        }

       
    }
}