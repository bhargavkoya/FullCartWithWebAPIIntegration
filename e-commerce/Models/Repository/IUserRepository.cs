using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Models.Repository
{
    public interface IUserRepository
    {
       Customer GetUser(Customer user);
    }
}
