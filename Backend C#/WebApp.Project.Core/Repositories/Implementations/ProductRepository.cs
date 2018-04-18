using System;
using System.Collections.Generic;
using WebApp.Project.Core.Models;
using System.Linq;
using MySql.Data.MySqlClient;
using Dapper;

namespace WebApp.Project.Core.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly string connectionString;
        
        public ProductRepository (string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<ProductModel> GetAll()
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<ProductModel>("select * from products").ToList();
            }
        }

    }
}
