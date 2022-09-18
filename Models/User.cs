using System.ComponentModel.DataAnnotations;

namespace WaterpoloAppNet.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Userame { get; set; }
        [Required]
        public string Password { get; set; }
        
        public string Role { get; set; } = "guest";
    }
}
