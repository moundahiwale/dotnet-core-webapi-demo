using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnet_core_webapi_demo.Data
{
    public class Repository : IRepository
    {

        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecasts()
        {
            return await _context.forecasts.ToListAsync();
        }

    }
}