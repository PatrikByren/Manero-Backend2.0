using System.ComponentModel.DataAnnotations;

namespace Manero.Models.Entities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        [Required]
        public string AddressTitle { get; set; } = null!;
        [Required]
        public string StreetName { get; set; } = null!;
        [Required]
        public string PostalCode { get; set; } = null!;
        [Required]
        public string City { get; set; } = null!;
        public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();
    }
}
