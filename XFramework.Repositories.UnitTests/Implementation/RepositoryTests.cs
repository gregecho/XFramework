using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFramework.Repositories.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XFramework.Repositories.Interfaces;
using Moq;
using XFramework.Models;
using System.Data.Entity;
namespace XFramework.Repositories.Implementation.UnitTests
{
    [TestClass()]
    public class RepositoryTests
    {
        Mock<IAmbientDbContextLocator> _mockAmbientDbContextLocator = null;
        Mock<OrionDbContext> _mockDbContext = null;
        IRepository<PmsOrder> _repository = null;
        Mock<DbSet<PmsOrder>> _mockDbSet = null;

        [TestInitialize()]
        public void Initialize()
        {
            _mockAmbientDbContextLocator = new Mock<IAmbientDbContextLocator>();
            _mockDbContext = new Mock<OrionDbContext>();
            _mockDbSet = new Mock<DbSet<PmsOrder>>();
            _mockAmbientDbContextLocator.Setup(x => x.Get<OrionDbContext>())
                .Returns(_mockDbContext.Object);
            _mockDbContext.Setup(x => x.Set<PmsOrder>())
                .Returns(_mockDbSet.Object);

            _repository = new PmsOrderRepository(_mockAmbientDbContextLocator.Object);
        }

        [TestCleanup()]
        public void Cleanup() { }

        [TestMethod()]
        public void Repository_Add_Test()
        {
            _repository.Add(new PmsOrder());

            //Verify
            _mockDbSet.Verify(x => x.Add(It.IsAny<PmsOrder>()), Times.Once);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "entity")]
        public void Repository_Add_Null_Throw_ArgumentNullException_Test()
        {
            PmsOrder order = null;
            _repository.Add(order);

            //Verify
            _mockDbSet.Verify(x => x.Add(It.IsAny<PmsOrder>()), Times.Never);
        }
    }
}
