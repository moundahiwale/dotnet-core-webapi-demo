using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_core_webapi_demo.Dtos
{
    public class ForecastForCreationDto
    {

        [Required]
        public int TemperatureC { get; set; }

        [Required]
        public string Summary { get; set; }
        public DateTime Date { get; set; }
        public ForecastForCreationDto()
        {
            Date = DateTime.Now;
        }
    }
}