using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;
using ValhallaApp.Domain.Entities;

namespace ValhallaApp.Domain.Interfaces
{
    public interface IUserService 
    {
        IEnumerable<UserResponse> GetUsers();

        void AddUser(CreateUserRequest user);

        void UpdateUser(UpdateUserRequest user);

        void DeleteUser(DeleteUserRequest user);
    }
}
