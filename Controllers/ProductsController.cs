using EFCFCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCFCore.Models;
using System.Net;

namespace EFCFCore.Controllers
{
    public class ProductsController : Controller
    {
        private ERPContext _erpcontext;
        public ProductsController(ERPContext erpcontext)         //constructor DI
        {
            _erpcontext = erpcontext;
        }
        public async Task<IActionResult> Index()                  //async method
        {
            return View(await _erpcontext.Products.ToListAsync());
        }


        //public IActionResult Index()                            //sync method
        //{
        //    return View(_erpcontext.Products.ToList());
        //}
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Descrption,Cost")] Product product)
        {
            if (ModelState.IsValid)
            {
                _erpcontext.Products.Add(product);
                await _erpcontext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
       public IActionResult Edit(int? Id)
        {
            return View(); 
            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,Title,Descrption,Cost")] Product product)
        {
            
            if (ModelState.IsValid)
            {
                _erpcontext.Entry(product).State = EntityState.Modified;
                await _erpcontext.SaveChangesAsync();
                RedirectToAction(nameof(Index));
            }
            return View(product);
        }








    }
}
