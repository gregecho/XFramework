using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFramework.Models;
using XFramework.Repositories.Interfaces;

namespace XFramework.Repositories.Implementation
{
    public class TodoRepository: Repository<XFrameworkContext, Todo>, ITodoRepository
    {
        public TodoRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }
    }
}
