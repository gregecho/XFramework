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
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IDbContextScopeFactory dbContextScopeFactory, IUserRepository todoRepository) :
            base(dbContextScopeFactory, todoRepository)
        {
            this.userRepository = todoRepository;
        }

        public User Find(User user)
        {
            using (var scope = dbContextScopeFactory.CreateReadOnly())
            {
                var result = userRepository.Query().FirstOrDefault(x => x.Name == user.Name && x.Password == user.Password);
                return result;
            }
        }
    }
}
