using e_commerce.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Models.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ShoppingDbContext _context;
        public UserRepository(ShoppingDbContext context)
        {
            _context = context;
        }
        public Customer GetUser(Customer user)
        {
            return _context.Customer.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
        }
    }
}
