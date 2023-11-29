using System.ComponentModel.DataAnnotations;

namespace Aggregation.Model
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required]
        [MaxLength(100)]
        public string ClientName { get; set; }  = string.Empty;

        [Required]
        [MaxLength(15)]
        public string NumberPhone { get; set; } = string.Empty;
    }
}
