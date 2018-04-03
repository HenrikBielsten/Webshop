using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Project.Core.Services.Implementations;
using Test.Project.Core.Repositories.Implementations;
using Test.Project.Core.Models;
using Microsoft.Extensions.Configuration;
using WebApp.Project.Core.Repositories.Implementations;
using WebApp.Project.Core.Models;

namespace WebApp.Project.Api.Controllers
{
    [Route("api/[controller]")]
    public class CartController : Controller
    {

        private readonly CartService cartService;

        public CartController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.cartService = new CartService(
                new CartRepository(connectionString));
        }

        // GET api/values
        [HttpGet]
        public List<CartProductModel> Get()
        {
            return this.cartService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{userid}")]
        public List<ProductModel> Get(string userid)
        {
            return this.cartService.Get(userid);
        }


        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]CartProductModel carts)
        {
            var result = this.cartService.AddToCart(carts);

            if (result)
            {
                return this.StatusCode(201);
            }
            else
            {
                return this.BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{cartid}/{productid}")]
        public bool Delete(string CartId, int ProductId)
        {

            return this.cartService.Delete(CartId, ProductId);

            //if (result)
            //{
            //    this.StatusCode(205);
            //}
            //else
            //{
            //    this.BadRequest();
            //}
        }
    }
}