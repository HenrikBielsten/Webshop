using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Project.Core.Services.Implementations;
using WebApp.Project.Core.Repositories.Implementations;
using WebApp.Project.Core.Models;
using Microsoft.Extensions.Configuration;

namespace WebApp.Project.Api.Controllers
{
    [Route("api/[controller]")]
    public class CheckoutController : Controller
    {

        private readonly CheckoutService checkoutService;

        public CheckoutController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.checkoutService = new CheckoutService(
                new CheckoutRepository(connectionString));
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public List<ProductModel> Get(string id)
        {
            return this.checkoutService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]CheckoutModel orders)
        {
            this.HttpContext.Response.StatusCode = 201;
            return this.checkoutService.AddToOrders(orders);
        }

    }
}

