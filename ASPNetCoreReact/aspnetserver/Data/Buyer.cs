using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Data
{
    internal sealed class Buyer
    {
        [Key]
        public int BuyerId { get; set; } 

        [Required]
        [MaxLength(32)]
        public int UserId { get; set; }

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
        [MaxLength(32)]
        public int CartID { get; set; }

    }


}
