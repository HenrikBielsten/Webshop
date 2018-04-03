using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Test.Project.Core.Models;
using Test.Project.Core.Repositories.Implementations;
using Test.Project.Core.Services.Implementations;

namespace Test.Project.Api.Controllers
{
    [Route("api/[controller]")]
    public class NewsController : Controller
    {

        private readonly NewsService newsService;

        public NewsController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.newsService = new NewsService(
                new NewsRepository(connectionString));
        }

        // GET api/values
        [HttpGet]
        public List<NewsModel> Get()
        {
            return this.newsService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public NewsModel Get(int id)
        {
            return this.newsService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]NewsModel news)
        {
            if (news.Id <= 0)
            {
                this.newsService.Create(news);
            }
            else
            {
                this.newsService.Edit(news);
            }
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
