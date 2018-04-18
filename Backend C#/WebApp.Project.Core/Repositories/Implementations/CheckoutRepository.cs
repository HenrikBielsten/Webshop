using System;
using System.Collections.Generic;
using WebApp.Project.Core.Models;
using System.Linq;
using MySql.Data.MySqlClient;
using Dapper;
namespace WebApp.Project.Core.Repositories.Implementations

{
    public class CheckoutRepository
    {
        private readonly string connectionString;

        public CheckoutRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<ProductModel> Get(string id)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<ProductModel>(
                    "select name, description, price, productimage, slug " +
                    "from Products join Carts ON Products.id = Carts.productid " +
                    "where Carts.cartid = @id", new { id }).ToList();
            }
        }
        public bool AddToOrders(CheckoutModel orders)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                try
                {
                    connection.Execute(
                        "insert into orders (price, adress, email, name) values (@price, @adress, @email, @name)",
                        new { price = @orders.price, adress = @orders.adress, email = @orders.email, name =@orders.name });

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