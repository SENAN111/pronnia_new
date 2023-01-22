using Microsoft.AspNetCore.Identity;

namespace PRONIYE_NEW.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
