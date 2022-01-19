using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Entities;

namespace User.Infrastructure.Contracts
{
    public interface IUserRepository : IGenericRepository<Users>
    {

    }
}
