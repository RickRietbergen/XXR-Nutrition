using Microsoft.AspNetCore.Identity;
using XXR_Nutrition.Data.Enum;

namespace XXR_Nutrition.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
