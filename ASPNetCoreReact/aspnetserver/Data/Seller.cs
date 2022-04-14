using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Data
{
    internal sealed class Seller
    {
        [Key]
        public int SellerId { get; set; }

        [Required]
        [MaxLength(32)]
        public int UserId { get; set; }


        [Required]
        [MaxLength(32)]
        public string name { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string Address { get; set; } = string.Empty;

    }


}
