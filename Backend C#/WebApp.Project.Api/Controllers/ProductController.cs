using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Project.Core.Services.Implementations;
using Microsoft.Extensions.Configuration;
using Test.Project.Core.Models;
using Test.Project.Core.Repositories.Implementations;

namespace WebApp.Project.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {

        private readonly ProductService productService;

        public ProductController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.productService = new ProductService(
                new ProductRepository(connectionString));
        }

        // GET api/values
        [HttpGet]
        public List<ProductModel> Get()
        {
            return this.productService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ProductModel Get(int id)
        {
            return this.productService.Get(id);
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]ProductModel news)
        //{
        //    if (news.Id <= 0)
        //    {
        //        this.productService.Create(news);
        //    }
        //    else
        //    {
        //        this.productService.Edit(news);
        //    }
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
