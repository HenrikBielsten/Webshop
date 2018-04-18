using System.Collections.Generic;
using WebApp.Project.Core.Models;

namespace WebApp.Project.Core.Repositories
{
    public interface IProductRepository
    {
        List<ProductModel> GetAll();
    }
}
