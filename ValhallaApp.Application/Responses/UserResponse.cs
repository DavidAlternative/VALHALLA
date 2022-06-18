using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaApp.Application.Responses
{
    public class UserResponse
    {
        public string UserId { get; set; } = null!;
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? FirstSurname { get; set; }
        public string? SecondSurname { get; set; }
        public string? Email { get; set; }
        public long? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Password { get; set; }
        public long? Dni { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? Region { get; set; }
    }
}
