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
        public int userType { get; set; }

    }


}
