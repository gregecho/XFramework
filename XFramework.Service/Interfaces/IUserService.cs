using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFramework.Models;

namespace XFramework.Services.Interfaces
{
    public interface IUserService: IService<User>
    {
        User Find(User user);
    }
}
