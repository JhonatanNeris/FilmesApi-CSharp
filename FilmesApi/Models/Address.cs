using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models

{
    public class Address
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

    }
}
