using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cardholders.Models
{
    public class Cardholder
    {
        [Key]
        public int id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string? name { get; set; }
        
        [Required]
        [RegularExpression("^[0-9]*$")]
        public string? cardNumber { get; set; }
        
        [Required]
        [RegularExpression("^[0-9]*$")]
        public string? cvc { get; set; }
        
        [Required]
        [RegularExpression(@"^(0[1-9]|1[0-2])/[0-9]{2}$", ErrorMessage = "Expiry date must be in MM/YY format")]
        public string? expiryDate { get; set; }
    }
}
