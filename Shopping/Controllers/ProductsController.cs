using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        public List<ProductModel> products = new List<ProductModel>()
        {
            new ProductModel() { Id = 1, Name = "Harmony Blue", Price = 119.95f, Image= "https://cdn.shopify.com/s/files/1/0066/8945/6243/products/IMPALA-HARMONY_1080X1080-5_6ae61ada-bd97-4506-8640-7d5ca29fa691_590x.jpg?v=1620237045" },
            new ProductModel() { Id = 2, Name = "Black", Price = 94.95f, Image = "https://cdn.shopify.com/s/files/1/0066/8945/6243/products/IMPALA_BLACK_004_1000_lifestyle_1000x_15bf2ad2-65de-48bc-a19a-020828d7d2e4_590x.jpg?v=1588701542" },
            new ProductModel() { Id = 3, Name = "White", Price = 94.95f, Image = "https://cdn.shopify.com/s/files/1/0066/8945/6243/products/IMPALA_1200X1200_PRODUCT-GALLERY_WHT3_1200x_40632efe-4d25-4cec-9aa5-06f21df35a58_590x.jpg?v=1593631032" },
            new ProductModel() { Id = 4, Name = "Sky Blue/Yellow", Price = 99.95f, Image = "https://cdn.shopify.com/s/files/1/0066/8945/6243/products/SKY-BLUE-QUAD_AD_1080x1080_1_590x.jpg?v=1603308984" },
            new ProductModel() { Id = 5, Name = "Pink Tartan", Price = 99.95f, Image = "https://cdn.shopify.com/s/files/1/0066/8945/6243/products/2000x2000px__0042_PhotoNov11_40457AM_394x.jpg?v=1621375736" }
        };

        
        // GET: /<controller>/
        public IActionResult Index(string color="white", string name = "han")
        {
            ViewData["products"] = products;
            ViewData["color"] = color;
            //ViewData["name"];
            return View();
        }

        public IActionResult Details(int? id)
        {
            ProductModel p = products.Find(item => item.Id == id);
            if(p == null)
            {
                //return Content("Couldn't find the product");
                return RedirectToAction("Index", "ErrorsHandlers");
            } else
            {
                ViewData["foundProduct"] = p;
                return View();
            }
        }

    }
}