using System.Collections.Generic;
using WebApp.Project.Core.Models;

namespace WebApp.Project.Core.Services
{
    public interface IProductService
    {
        List<ProductModel> GetAll();
    }
}
