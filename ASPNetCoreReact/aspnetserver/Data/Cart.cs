using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Data
{
    internal sealed class Cart
    {
        [Key]
        public int CartID { get; set; }

        [Required]
        [MaxLength(999999)]
        public string cartItems { get; set; }
        
        [Required]
        [MaxLength(9999)]
        public int BuyerID { get; set; }

        [Required]
        [MaxLength(999999)]
        public string Quantity { get; set; }
    }


}
