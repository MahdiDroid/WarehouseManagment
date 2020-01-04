using System;
using System.Collections.Generic;
using System.Text;

namespace WM.BL
{
    public class UserRepository : IRepository<User>
    {
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public User RetrieveById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
