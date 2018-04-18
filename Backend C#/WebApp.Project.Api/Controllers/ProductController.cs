﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Project.Core.Services.Implementations;
using Microsoft.Extensions.Configuration;
using WebApp.Project.Core.Models;
using WebApp.Project.Core.Repositories.Implementations;
using WebApp.Project.Core.Repositories;
using WebApp.Project.Core.Services;


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
