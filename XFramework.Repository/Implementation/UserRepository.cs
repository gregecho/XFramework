using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFramework.Models;
using XFramework.Repositories.Interfaces;

namespace XFramework.Repositories.Implementation
{
    public class UserRepository : Repository<XFrameworkContext, User>, IUserRepository
    {
        public UserRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }
    }
}
