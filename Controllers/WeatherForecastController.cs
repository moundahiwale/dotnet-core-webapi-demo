using System.Threading.Tasks;
using AutoMapper;
using dotnet_core_webapi_demo.Data;
using dotnet_core_webapi_demo.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_webapi_demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepository _repo;
        private readonly IMapper _mapper;

        public WeatherForecastController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var forceasts = await _repo.GetForecasts();
            return Ok(forceasts);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ForecastForCreationDto forecastForCreationDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var forecastToCreate = _mapper.Map<WeatherForecast>(forecastForCreationDto);
            _repo.Add<WeatherForecast>(forecastToCreate);
            if (await _repo.SaveAll())
            {
                return Ok();
            }
            return BadRequest("Could not add the forecast");
        }
    }
}
