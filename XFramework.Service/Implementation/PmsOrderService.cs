using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFramework.Models;
using XFramework.Repositories;
using XFramework.Repositories.Interfaces;
using XFramework.Services.Interfaces;

namespace XFramework.Services.Implementation
{
    public class PmsOrderService : Service<PmsOrder>, IPmsOrderService
    {
        private readonly IPmsOrderRepository pmsOrderRepository;
        public PmsOrderService(IDbContextScopeFactory dbContextScopeFactory, IPmsOrderRepository pmsOrderRepository) :
            base(dbContextScopeFactory, pmsOrderRepository)
        {
            this.pmsOrderRepository = pmsOrderRepository;
        }
    }
}
