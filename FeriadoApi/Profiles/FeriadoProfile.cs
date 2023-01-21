using AutoMapper;
using FeriadoApi.Entities;

namespace FeriadoApi.Profiles
{
    public class FeriadoProfile : Profile
    {
        public FeriadoProfile() {

            CreateMap<FeriadoDto, Feriado>();
        }
    }
}
