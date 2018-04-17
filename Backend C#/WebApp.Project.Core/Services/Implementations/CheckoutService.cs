using System;
using System.Collections.Generic;
using WebApp.Project.Core.Repositories.Implementations;
using WebApp.Project.Core.Models;
using Test.Project.Core.Models;
namespace WebApp.Project.Core.Services.Implementations
{
    public class CheckoutService
    {
        private readonly CheckoutRepository CheckoutRepository;

        public CheckoutService(CheckoutRepository CheckoutRepository)
        {
            this.CheckoutRepository = CheckoutRepository;
        }
        public List<ProductModel> Get(string id)
        {
            return this.CheckoutRepository.Get(id);
        }
        public bool AddToOrders(CheckoutModel orders)
        {
            return this.CheckoutRepository.AddToOrders(orders);
        }
    }
}