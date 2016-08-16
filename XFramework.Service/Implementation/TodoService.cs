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
    public class TodoService: Service<Todo>, ITodoService
    {
        private readonly ITodoRepository todoRepository;
        public TodoService(IDbContextScopeFactory dbContextScopeFactory, ITodoRepository todoRepository) :
            base(dbContextScopeFactory, todoRepository)
        {
            this.todoRepository = todoRepository;
        }
    }
}
