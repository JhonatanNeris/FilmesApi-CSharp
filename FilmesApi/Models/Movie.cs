using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; } 
        [Required(ErrorMessage = "O título do filme é obrigatório!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "O gênero do filme é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O gênero não pode exceder 50 caracteres.")]
        public string Genre { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "A duração do filme deve ser entre 70 e 600 minutos.")]
        public int DurationInMinutes { get; set; }
    }
}
