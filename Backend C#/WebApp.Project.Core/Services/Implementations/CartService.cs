using System;
using System.Collections.Generic;
using WebApp.Project.Core.Repositories.Implementations;
using WebApp.Project.Core.Models;

namespace WebApp.Project.Core.Services.Implementations
{
    public class CartService
    {
        private readonly CartRepository cartRepository;

        public CartService(CartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public List<CartProductModel> GetAll()
        {
            return this.cartRepository.GetAll();
        }

        public List<ProductModel> Get(string id)
        {
            return this.cartRepository.Get(id);
        }

        public bool AddToCart(CartProductModel carts)
        {
            //if (int.Equals(carts.ProductId) || int.IsNullOrEmpty(carts.CartId))
            //{
            //    return false;
            //}
            return this.cartRepository.AddToCart(carts);
        }

        public bool Edit(CartProductModel carts)
        {
            //if (int.IsNullOrEmpty(carts.ProductId) || int.IsNullOrEmpty(carts.CartId))
            //{
            //    return false;
            //}

            return this.cartRepository.Edit(carts);
        }

        public bool Delete(string CartId, int ProductId)
        {
            return this.cartRepository.Delete(CartId, ProductId);
        }

    }
}