using AutoMapper;
using dotnet_core_webapi_demo.Dtos;

namespace dotnet_core_webapi_demo.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ForecastForCreationDto, WeatherForecast>();
        }
    }
}