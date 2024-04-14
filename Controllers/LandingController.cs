using E_Commerce_Web_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Web_Application.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            Random rand = new Random();
            for(int i = 1;i < 15;i++)
            {
                Product product = new Product();
                product.Title = "Product_" + i.ToString();
                product.Description = "Product Description_" + i.ToString();
                product.ProductId = i;
                product.Price = i * 500;
                product.PercentageOff = rand.Next(15, 50);
                product.PriceAfterOff = product.Price - (product.Price*product.PercentageOff)/100;
                product.Rating = rand.NextInt64(1,5);
                product.NoofRatings = rand.Next(10000000).ToString("N0");
                product.ImageLink.Add("P" +  i.ToString() + ".png");

                products.Add(product);
            }

            return View(products);
        }
    }
}
