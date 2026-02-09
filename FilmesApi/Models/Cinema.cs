using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; } 
        [Required(ErrorMessage = "O nome do cinema é obrigatório!")]
        public string Name { get; set; }       

    }
}
