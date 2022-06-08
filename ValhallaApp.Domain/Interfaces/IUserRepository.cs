using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;

namespace ValhallaApp.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();

        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);
    }
}
