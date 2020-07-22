using Microsoft.EntityFrameworkCore;

namespace dotnet_core_webapi_demo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<WeatherForecast> forecasts { get; set; }
    }
}