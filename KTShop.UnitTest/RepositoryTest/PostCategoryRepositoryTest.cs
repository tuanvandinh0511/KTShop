using KTShop.Data.Infrastructure;
using KTShop.Data.Repositories;
using KTShop.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory _dbFactory;
        private IPostCategoryRepository _objRepository;
        private IUnitOfWork _unitOfWork;

        [TestInitialize]
        public void Initalize()
        {
            _dbFactory = new DbFactory();
            _objRepository = new PostCategoryRepository(_dbFactory);
            _unitOfWork = new UnitOfWork(_dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = _objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count());
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory postCategory = new PostCategory();
            postCategory.Name = "Test1";
            postCategory.Alias = "Test1";
            postCategory.Status = true;

            var result = _objRepository.Add(postCategory);
            _unitOfWork.Commit();

            Assert.IsNotNull(result);
           
        }


    }
}
