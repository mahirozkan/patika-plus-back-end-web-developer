using Microsoft.AspNetCore.Mvc;
using BasicMVC.Models;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new()
            {
                Id = 1,
                FirstName = "Walter",
                LastName = "Mitty",
                Email = "walter.mitty@gmail.com"
            };

            List<Order> orders = new()
            {
                new(1, "Bounty", 20, 2),
                new(2, "Snickers", 15, 2),
                new(3, "Fiorella Biscuit", 45, 1),
                new(4, "Doritos Nacho", 49, 1)
            };

            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
