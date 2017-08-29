using KTShop.Data.Infrastructure;
using KTShop.Data.Repositories;
using KTShop.Model.Models;
using KTShop.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory>  _listPostCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listPostCategory = new List<PostCategory>()
            {
                new PostCategory() {ID=1, Name="Test1",Alias="Test1",Status =true },
                new PostCategory() {ID=2, Name="Test2",Alias="Test2",Status =true },
                new PostCategory() {ID=3, Name="Test3",Alias="Test3",Status =true }
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //SetUp Method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listPostCategory);
            //Call Action
           var result = _categoryService.GetAll() as List<PostCategory>;
            //compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());

        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory postCategory = new PostCategory();
            postCategory.Name = "Name1";
            postCategory.Alias = "Alias1";
            postCategory.Status = true;

            _mockRepository.Setup(m => m.Add(postCategory)).Returns((PostCategory p) =>
              {
                  p.ID = 1;
                  return p;
              });

            var result = _categoryService.Add(postCategory);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, postCategory.ID);
            
        }

    }
}
