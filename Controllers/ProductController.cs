using Microsoft.AspNetCore.Mvc;
using products.Models;
using System.Collections.Generic;

namespace products.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index(string search)
        {
            Product product1 = new Product
            { Id = 1,
              Image = "mercedes.jpg",
              Name="Test1",
                Content = "Test Desc 1",
                Price = "Price:103$"
            };
            Product product2 = new Product
            {
                Id = 2,
                Image = "minicooper.jpg",
                Name = "Test2",
                Content = "Test Desc 2",
                Price = "Price:110$"
            };
            Product product3 = new Product
            {
                Id = 3,
                Image = "mustang.jpg",
                Name = "Test3",
                Content = "Test Desc 3",
                Price= "Price:120$"
            };

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            if (!string.IsNullOrWhiteSpace(search))
            {
                products = products.FindAll(p => p.Name.ToLower().Contains(search.ToLower()));
                if (products.Count == 0)
                    return NotFound();
            }
            return View(products);

        }
        public IActionResult Detail(int Id)
        {
            Product product1 = new Product
            {
                Id = 1,
                Image = "mercedes.jpg",
                Name = "Test1",
                Content = "Test Desc 1",
                Price = "Price:103$",
                Color= "Aluminium",
                Description= "Lorem Ipsum is simply dummy text of the" +
                " printing and typesetting industry. Lorem Ipsum has been" +
                " the industry's standard dummy text ever since the 1500s," +
                " when an unknown printer took a galley of type and scrambled it" +
                " to make a type specimen book."
            };
            Product product2 = new Product
            {
                Id = 2,
                Image = "minicooper.jpg",
                Name = "Test2",
                Content = "Test Desc 2",
                Price = "Price:110$",
                Color = "Green",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                " Lorem Ipsum has been the industry's standard dummy text ever since the"
            };
            Product product3 = new Product
            {
                Id = 3,
                Image = "mustang.jpg",
                Name = "Test3",
                Content = "Test Desc 3",
                Price = "Price:120$",
                Color="Red",
                Description= "It is a long established fact that a reader will be" +
                " distracted by the readable content of a page when looking at its layout. " +
                "The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters," +
                " as opposed to using 'Content here, content here', making it look like readable English."
            };

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            products = products.FindAll(p => p.Id==Id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products) ;
            
        }
    }
}
