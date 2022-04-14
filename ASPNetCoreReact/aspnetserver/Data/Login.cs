using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Data
{
    internal sealed class Login
    {

        
        [Required]
        [MaxLength(16)]

        public string username { get; set; } = string.Empty;

        [Required]
        [MaxLength(16)]
        public string password { get; set; } = string.Empty;



    }


}
