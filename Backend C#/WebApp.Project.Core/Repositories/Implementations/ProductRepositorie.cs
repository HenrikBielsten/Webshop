using System;
using System.Collections.Generic;
using Test.Project.Core.Models;
using System.Linq;
using MySql.Data.MySqlClient;
using Dapper;

namespace Test.Project.Core.Repositories.Implementations
{
    public class ProductRepository
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

        public ProductModel Get(int id)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.QuerySingleOrDefault<ProductModel>("select * from products where id = @id", new { id });
            }
        }

   //     public bool Create(ProductModel product)
   //     {
   //         using (var connection = new MySqlConnection(this.connectionString))
   //         {
   //             try
   //             {
			//		connection.Execute(
   //                     "insert into products (Id, Slug, Name, Description) values(@id, @slug)", 
   //                     new { Id = @product.Id, Slug = @product.Slug });
                    
   //             }
   //             catch (Exception)
   //             {
   //                 return false;
   //             }
   //         }

			//return true;
   //     }

   //     public bool Edit(ProductModel product)
   //     {
   //         using (var connection = new MySqlConnection(this.connectionString))
   //         {
   //             try
   //             {
			//		connection.Execute(
   //                     "update products set id = @Id, slug = @Slug where id = @Id",
   //                     new {header = @product.Id, body = @product.Slug, id = @product.Id, });
                    
   //             }
   //             catch(Exception)
   //             {
   //                 return false;
   //             }
   //         }
			//return true;
        //}
    }
}
