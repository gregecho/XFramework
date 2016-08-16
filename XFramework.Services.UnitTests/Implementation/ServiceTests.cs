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
        private Mock<IPmsOrderRepository> _mockRepository;
        private IService<PmsOrder> _service;
        Mock<IDbContextScopeFactory> _mockDbContextScopeFactory;
        Mock<IDbContextScope> _mockDbContextScope;
        List<PmsOrder> listPmsOrder;

        [TestInitialize]
        public void Initialize()
        {
            // Mock
            _mockRepository = new Mock<IPmsOrderRepository>();
            _mockDbContextScopeFactory = new Mock<IDbContextScopeFactory>();
            _mockDbContextScope = new Mock<IDbContextScope>();

            _mockDbContextScopeFactory.Setup(x => x.Create(It.IsAny<DbContextScopeOption>()))
                .Returns<DbContextScopeOption>((option) => _mockDbContextScope.Object);

            _service = new PmsOrderService(_mockDbContextScopeFactory.Object, _mockRepository.Object);

            // Should not test specify object in memory
            listPmsOrder = new List<PmsOrder>() { 
             new PmsOrder() { Id = 1, OrderName = "US" }, 
             new PmsOrder() { Id = 2, OrderName = "India" }, 
             new PmsOrder() { Id = 3, OrderName = "Russia" } 
            };
        }

        [TestMethod()]
        public void Service_Query_Test()
        {
            //Arrange 
            _mockRepository.Setup(x => x.Query(null)).Returns(listPmsOrder.AsQueryable());
            //Act 
            List<PmsOrder> results = _service.Query().ToList();

            //Assert 
            Assert.IsNotNull(results);
            Assert.AreEqual(3, results.Count);

        }

        [TestMethod()]
        public void Service_Query_WithPredict_Test()
        {
            //Arrange 
            _mockRepository.Setup(x => x.Query(It.IsAny<Expression<Func<PmsOrder, bool>>>()))
                  .Returns<Expression<Func<PmsOrder, bool>>, Expression<Func<PmsOrder, object>>[]>((predict, pathes) =>
                    listPmsOrder.Where(predict.Compile()).AsQueryable()
                );
            //.Callback<Expression<Func<PmsOrder, bool>>, Expression<Func<PmsOrder, object>>[]>((predict, pathes) =>
            // {
            //     listPmsOrder.Where(predict.Compile()).AsQueryable();
            // });

            //Act 
            List<PmsOrder> results = _service.Query(x => x.OrderName == "US").ToList();

            //Assert 
            Assert.IsNotNull(results);
            Assert.AreEqual(1, results.Count);

            //Verify
            _mockRepository.Verify(x => x.Query(It.IsAny<Expression<Func<PmsOrder, bool>>>()
                , It.IsAny<Expression<Func<PmsOrder, object>>[]>()), Times.Once);
        }

        [TestMethod]
        public void Service_Add_One_Test()
        {
            // Stub
            _mockRepository.Setup(x => x.Add(It.IsAny<PmsOrder>()))
                .Returns<PmsOrder>((entity) =>
                     entity
                    )
                .Callback<PmsOrder>((entity) =>
                  {
                      listPmsOrder.Add(entity);
                  });

            //Act 
            var result = _service.Add(new PmsOrder { Id = 10, OrderName = "China" });
            //Assert 
            Assert.IsNotNull(result);
            Assert.AreEqual(4, listPmsOrder.Count);
            //Verify
            _mockRepository.Verify(x => x.Add(It.IsAny<PmsOrder>()), Times.Once);
        }

        [TestMethod]
        public void Service_Add_Many_Test()
        {
            _mockRepository.Setup(x => x.Add(It.IsAny<IQueryable<PmsOrder>>()))
               .Callback<IQueryable<PmsOrder>>((entity) =>
               {
                   foreach (var item in entity)
                   {
                       listPmsOrder.Add(item);
                   }
               });

            var listPmsOrderInsert = new List<PmsOrder>() { 
             new PmsOrder() { Id = 11, OrderName = "US1" }, 
             new PmsOrder() { Id = 12, OrderName = "India1" }, 
             new PmsOrder() { Id = 13, OrderName = "Russia1" } 
            };

            //Act 
            _service.Add(listPmsOrderInsert.AsQueryable());
            //Assert 
            Assert.AreEqual(6, listPmsOrder.Count);
            //Verify???
            _mockRepository.Verify(x => x.Add(It.IsAny<IQueryable<PmsOrder>>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Once);
        }

        [TestMethod()]
        public void Service_Delete_Entity_Test()
        {
            _mockRepository.Setup(x => x.Delete(It.IsAny<PmsOrder>()))
              .Callback<PmsOrder>((entity) =>
              {
                  listPmsOrder.Remove(entity);
              });

            //Act 
            _service.Delete(listPmsOrder.FirstOrDefault());
            //Assert 
            Assert.AreEqual(2, listPmsOrder.Count);
            //Verify
            _mockRepository.Verify(x => x.Delete(It.IsAny<PmsOrder>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Once);
        }

        [TestMethod()]
        public void Service_Delete_Not_Exist_Entity_Test()
        {
            _mockRepository.Setup(x => x.Delete(It.IsAny<PmsOrder>()))
              .Callback<PmsOrder>((entity) =>
              {
                  listPmsOrder.Remove(entity);
              });

            //Act 
            _service.Delete(new PmsOrder());
            //Assert 
            Assert.AreEqual(3, listPmsOrder.Count);
            //Verify
            _mockRepository.Verify(x => x.Delete(It.IsAny<PmsOrder>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Once);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "entity")]
        public void Service_Delete_Null_Entity_Test()
        {
            PmsOrder order = null;
            _mockRepository.Setup(x => x.Delete(order))
              .Throws<ArgumentNullException>();

            //Act 
            _service.Delete(order);
            //Assert 
            Assert.AreEqual(3, listPmsOrder.Count);
            //Verify
            _mockRepository.Verify(x => x.Delete(It.IsAny<PmsOrder>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Never);
        }

        [TestMethod]
        public void Service_Delete_Many_Entity_Test()
        {
            _mockRepository.Setup(x => x.Delete(It.IsAny<IQueryable<PmsOrder>>()))
             .Callback<IQueryable<PmsOrder>>((entity) =>
             {
                 for (int i = 0; i < entity.Count(); i++)
                 {
                     listPmsOrder.Remove(entity.ElementAt(i));
                 }
             });
            var deltedPmsOrderList = listPmsOrder.Where(x => x.Id > 1);
            //Act 
            _service.Delete(deltedPmsOrderList.AsQueryable());
            //Assert 
            //Assert.AreEqual(1, listPmsOrder.Count);
            //Verify
            _mockRepository.Verify(x => x.Delete(It.IsAny<IQueryable<PmsOrder>>()), Times.Once);
            _mockDbContextScope.Verify(x => x.SaveChanges(), Times.Once);
        }
    }
}
