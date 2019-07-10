using ECommerceNoSQL.Domain.Entities;
using ECommerceNoSQL.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceNoSQL.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
