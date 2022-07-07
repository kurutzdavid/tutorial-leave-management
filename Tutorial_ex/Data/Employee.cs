using Microsoft.AspNetCore.Identity;

namespace Tutorial_ex.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string taxId { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
