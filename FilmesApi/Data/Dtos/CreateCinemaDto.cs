using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O nome do cinema é obrigatório!")]
        public string Name { get; set; }
        public int AddressId { get; set; }

    }
}
