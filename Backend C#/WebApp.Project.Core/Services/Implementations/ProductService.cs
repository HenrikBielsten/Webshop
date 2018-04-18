using System;
using System.Collections.Generic;
using WebApp.Project.Core.Models;
using WebApp.Project.Core.Repositories;
using WebApp.Project.Core.Repositories.Implementations;

namespace WebApp.Project.Core.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<ProductModel> GetAll()
        {
            return this.productRepository.GetAll();
        }

    }
}
