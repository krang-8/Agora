using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Data
{
    internal sealed class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        [MaxLength(999999)]

        public string ToAddress { get; set; }
        [Required]
        [MaxLength(999999)]

        public string FromAddress { get; set; }

        [Required]
        [MaxLength(9999)]

        public int BuyerID { get; set; }


    }


}
