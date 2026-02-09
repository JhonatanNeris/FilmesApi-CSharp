using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class UpdateAddressDto
    {
        public string Street { get; set; }
        public int Number { get; set; }
    }
}
