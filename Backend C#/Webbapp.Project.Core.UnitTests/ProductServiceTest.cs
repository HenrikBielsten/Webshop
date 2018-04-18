using System.Collections.Generic;
using FakeItEasy;
using NUnit.Framework;
using WebApp.Project.Core.Models;
using WebApp.Project.Core.Repositories;
using WebApp.Project.Core.Services.Implementations;

namespace Webbapp.Project.Core.UnitTests.Services
{
    public class ProductServiceTests
    {
        private ProductService productService;
        private IProductRepository productRepository;

        [SetUp]
        public void SetUp()
        {
            this.productRepository = A.Fake<IProductRepository>();
            this.productService = new ProductService(this.productRepository);
        }

        [Test]
        public void GetAll_ReturnsProductList()
        {
            //Arrange
            var expectedProducts = new List<ProductModel>
           {
               new ProductModel { }
           };

            A.CallTo(() => productRepository.GetAll()).Returns(expectedProducts);

            //Act
            var result = productService.GetAll();

            //Assert
            Assert.That(result, Is.EqualTo(expectedProducts));
        }
    }
}
