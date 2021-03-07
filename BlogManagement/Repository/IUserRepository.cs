using BlogManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Repository
{
    public interface IUserRepository : IBaseRepository<UserDetails>
    {
    }
}
