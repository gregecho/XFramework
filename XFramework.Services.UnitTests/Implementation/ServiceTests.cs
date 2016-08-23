using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XFramework.Models;
using Moq;
using XFramework.Repositories.Interfaces;
using XFramework.Services.Interfaces;
using XFramework.Repositories;
using System.Linq.Expressions;
using XFramework.Services.Implementation;

namespace XFramework.Services.Implementation.UnitTests
{
    [TestClass()]
    public class ServiceTests
    {
        private Mock<IUserRepository> _mockRepository;
        private IService<User> _service;
        Mock<IDbContextScopeFactory> _mockDbContextScopeFactory;
        Mock<IDbContextScope> _mockDbContextScope;
        List<User> listUser;

        [TestInitialize]
        public void Initialize()
        {
            // Mock
            _mockRepository = new Mock<IUserRepository>();
            _mockDbContextScopeFactory = new Mock<IDbContextScopeFactory>();
            _mockDbContextScope = new Mock<IDbContextScope>();

            _mockDbContextScopeFactory.Setup(x => x.Create(It.IsAny<DbContextScopeOption>()))
                .Returns<DbContextScopeOption>((option) => _mockDbContextScope.Object);

            _service = new UserService(_mockDbContextScopeFactory.Object, _mockRepository.Object);

            // Should not test specify object in memory
            listUser = new List<User>() { 
             new User() { ID = 1, Name = "US" }, 
             new User() { ID = 2, Name = "India" }, 
             new User() { ID = 3, Name = "Russia" } 
            };
        }

        [TestMethod()]
        public void Service_Query_Test()
        {
            //Arrange 
            _mockRepository.Setup(x => x.Query(null)).Returns(listUser.AsQueryable());
            //Act 
            List<User> results = _service.Query().ToList();

            //Assert 
            Assert.IsNotNull(results);
            Assert.AreEqual(3, results.Count);

        }

        [TestMethod()]
        public void Service_Query_WithPredict_Test()
        {
            //Arrange 
            _mockRepository.Setup(x => x.Query(It.IsAny<Expression<Func<User, bool>>>()))
                  .Returns<Expression<Func<User, bool>>, Expression<Func<User, object>>[]>((predict, pathes) =>
                    listUser.Where(predict.Compile()).AsQueryable()
                );
            //.Callback<Expression<Func<User, bool>>, Expression<Func<User, object>>[]>((predict, pathes) =>
            // {
            //     listUser.Where(predict.Compile()).AsQueryable();
            // });

            //Act 
            List<User> results = _service.Query(x => x.Name == "US").ToList();

            //Assert 
            Assert.IsNotNull(results);
            Assert.AreEqual(1, results.Count);

            //Verify
            _mockRepository.Verify(x => x.Query(It.IsAny<Expression<Func<User, bool>>>()
                , It.IsAny<Expression<Func<User, object>>[]>()), Times.Once);
        }

        [TestMethod]
        public void Service_Add_One_Test()
        {
            // Stub
            _mockRepository.Setup(x => x.Add(It.IsAny<User>()))
                .Returns<User>((entity) =>
                     entity
                    )
                .Callback<User>((entity) =>
                  {
                      listUser.Add(entity);
                  });

            //Act 
            var result = _service.Add(new User { ID = 10, Name = "China" });
            //Assert 
            Assert.IsNotNull(result);
            Assert.AreEqual(4, listUser.Count);
            //Verify
            _mockRepository.Verify(x => x.Add(It.IsAny<User>()), Times.Once);
        }

        [TestMethod]
        public void Service_Add_Many_Test()
        {
            _mockRepository.Setup(x => x.Add(It.IsAny<IQueryable<User>>()))
               .Callback<IQueryable<User>>((entity) =>
               {
                   foreach (var item in entity)
                   {
                       listUser.Add(item);
                   }
               });

            var listUserInsert = new List<User>() { 
             new User() { ID = 11, Name = "US1" }, 
             new User() { ID = 12, Name = "India1" }, 
             new User() { ID = 13, Name = "Russia1" } 
            };

            //Act 
            _service.Add(listUserInsert.AsQueryable());
            //Assert 
            Assert.AreEqual(6, listUser.Count);
            //Verify???
            _mockRepository.Verify(x => x.Add(It.IsAny<IQueryable<User>>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Once);
        }

        [TestMethod()]
        public void Service_Delete_Entity_Test()
        {
            _mockRepository.Setup(x => x.Delete(It.IsAny<User>()))
              .Callback<User>((entity) =>
              {
                  listUser.Remove(entity);
              });

            //Act 
            _service.Delete(listUser.FirstOrDefault());
            //Assert 
            Assert.AreEqual(2, listUser.Count);
            //Verify
            _mockRepository.Verify(x => x.Delete(It.IsAny<User>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Once);
        }

        [TestMethod()]
        public void Service_Delete_Not_Exist_Entity_Test()
        {
            _mockRepository.Setup(x => x.Delete(It.IsAny<User>()))
              .Callback<User>((entity) =>
              {
                  listUser.Remove(entity);
              });

            //Act 
            _service.Delete(new User());
            //Assert 
            Assert.AreEqual(3, listUser.Count);
            //Verify
            _mockRepository.Verify(x => x.Delete(It.IsAny<User>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Once);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "entity")]
        public void Service_Delete_Null_Entity_Test()
        {
            User order = null;
            _mockRepository.Setup(x => x.Delete(order))
              .Throws<ArgumentNullException>();

            //Act 
            _service.Delete(order);
            //Assert 
            Assert.AreEqual(3, listUser.Count);
            //Verify
            _mockRepository.Verify(x => x.Delete(It.IsAny<User>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Never);
        }

        [TestMethod]
        public void Service_Delete_Many_Entity_Test()
        {
            _mockRepository.Setup(x => x.Delete(It.IsAny<IQueryable<User>>()))
             .Callback<IQueryable<User>>((entity) =>
             {
                 for (int i = 0; i < entity.Count(); i++)
                 {
                     listUser.Remove(entity.ElementAt(i));
                 }
             });
            var deltedUserList = listUser.Where(x => x.ID > 1);
            //Act 
            _service.Delete(deltedUserList.AsQueryable());
            //Assert 
            //Assert.AreEqual(1, listUser.Count);
            //Verify
            _mockRepository.Verify(x => x.Delete(It.IsAny<IQueryable<User>>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Once);
        }
    }
}
