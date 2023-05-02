using Manero.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Manero.Models.Identity
{
    public class AppUser : IdentityUser
    {
        [ProtectedPersonalData]
        [Required]
        public string Name { get; set; } = null!;
        public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();

    }
}
