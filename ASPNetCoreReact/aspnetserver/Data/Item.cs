using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Data
{
    internal sealed class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        [MaxLength(9999)]
        public int itemPrice { get; set; }
        
        [Required]
        [MaxLength(9999)]
        public int SellerID { get; set; }

        [Required]
        [MaxLength(9999)]
        public int stock { get; set; }


        [Required]
        [MaxLength(100)]

        public string itemName { get; set; } = string.Empty;

        [Required]
        [MaxLength(10000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(10000)]
        public string image { get; set; } = string.Empty;

    }


}
