namespace FilmesApi.Data.Dtos;

public class ReadMovieDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int DurationInMinutes { get; set; }
    public DateTime AppointmentTime { get; set; } = DateTime.Now;
}
