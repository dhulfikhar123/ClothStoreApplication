using Microsoft.AspNetCore.Identity;

namespace ClothStoreApplication.ViewModels
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
