using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;
using ValhallaApp.Infrastructure.Persistence;

namespace ValhallaApp.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ValhallaContext _context;

        public UserRepository(ValhallaContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            
        } 

        public void UpdateUser(User user)
        {
            var UserE = _context.Users.FirstOrDefault(x => x.UserId == user.UserId);
            if (UserE != null)
            {
                UserE.UserName = user.UserName;
                UserE.FirstName = user.FirstName;
                UserE.SecondName = user.SecondName;
                UserE.FirstSurname = user.FirstSurname;
                UserE.SecondSurname = user.SecondSurname;
                UserE.Email = user.Email;
                UserE.Phone = user.Phone;
                UserE.Address = user.Address;
                UserE.Birthdate = user.Birthdate;
                UserE.Password = user.Password;
                UserE.Dni = user.Dni;
                UserE.City = user.City;
                UserE.Country = user.Country;
                UserE.PostalCode = user.PostalCode;
                UserE.Region = user.Region;
            }
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            var UserE = _context.Users.FirstOrDefault(x => x.UserId == user.UserId);

            if (UserE != null) _context.Remove(UserE);
            _context.SaveChanges();
        }
    }
}
