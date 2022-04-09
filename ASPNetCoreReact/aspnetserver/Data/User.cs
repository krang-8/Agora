using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Data
{
    internal sealed class User
    {
        [Key]
        public int UserId { get; set; }
        
        [Required]
        [MaxLength(16)]

        public string username { get; set; } = string.Empty;

        [Required]
        [MaxLength(16)]
        public string password { get; set; } = string.Empty;

        [Required]
        [MaxLength(32)]
        public string name { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string Address1 { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string Address2 { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string Address3 { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public int cartID { get; set; }

        [Required]
        public int userType { get; set; }

    }


}
