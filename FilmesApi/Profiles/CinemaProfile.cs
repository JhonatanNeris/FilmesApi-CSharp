using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                            .ForMember(cinemaDto => cinemaDto.Address,
                                opt => opt.MapFrom(cinema => cinema.Address));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
