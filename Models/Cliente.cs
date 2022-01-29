using System.ComponentModel.DataAnnotations;

namespace app.Models{
 
    public class Cliente{

        [Key]
        public int Id { get; set; }
        public string Data { get; set; }
        [Required(ErrorMessage ="O campo nome não pode ser nulo")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="O campo telefone não pode ser nulo")]
        public string Telefone { get; set; }
        [Required(ErrorMessage ="O campo email não pode ser nulo")]
        public string Email { get; set; }
        [Required(ErrorMessage ="O campo cep não pode ser nulo")]
        public string Cep { get; set; }

    }


}