using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class Usuario
    {
        [Key]
        public int id{ get; set; }
        public string data{ get; set; }
        [Required(ErrorMessage ="O campo usuario não pode ser nulo")]
        public string username{ get; set; }
        [Required(ErrorMessage ="O campo senha não pode ser nulo")]
        public string password{ get; set; }
    }
}