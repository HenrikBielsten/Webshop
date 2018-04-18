using System;
using System.Collections.Generic;
using WebApp.Project.Core.Models;
using System.Linq;
using MySql.Data.MySqlClient;
using Dapper;

namespace WebApp.Project.Core.Repositories.Implementations
{
    public class CartRepository
    {
        private readonly string connectionString;

        public CartRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<CartProductModel> GetAll()
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<CartProductModel>("select * from carts").ToList();
            }
        }

        public List<ProductModel> Get(string userid)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<ProductModel>(
                    "select name, description, price, productimage, id, slug " +
                    "from Products join Carts ON Products.id = Carts.productid " +
                    "where Carts.cartid = @userid", new { userid }).ToList();
            }

        }

        public bool AddToCart(CartProductModel carts)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                try
                {
                    connection.Execute(
                        "insert into carts (productid, cartid) values(@productid, @cartid)",
                        new { productid = @carts.ProductId, cartid = @carts.CartId });

                }
                catch (Exception)
                {
                    return false;
                }
            }

            return true;
        }

        public bool Edit(CartProductModel carts)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                try
                {
                    connection.Execute(
                        "update carts set productid = @ProductId, cartid = @CartId where id = @Id",
                        new { productid = @carts.ProductId, cartid = @carts.CartId });

                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        public bool Delete(string CartId, int ProductId)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                try
                {
                    connection.Execute(
                        "delete from carts where productid = @ProductId and cartid = @CartId limit 1",
                        new { ProductId = @ProductId, CartId = @CartId });

                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }
    }
}