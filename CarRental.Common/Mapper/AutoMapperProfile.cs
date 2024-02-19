using AutoMapper;
using CarRental.Common.DTOs;
using CarRental.Data;

namespace CarRental.Common.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Vehicle, VehicleDto>()
                .ForMember(d => d.VehicleType, o => o.MapFrom(s => s.VehicleType.Name))
                .ForMember(d => d.Location, o => o.MapFrom(s => string.Concat(s.Location.Name, ", ", s.Location.City, ", ", s.Location.State, ", ", s.Location.Country)));
                
            
        }
    }
}
