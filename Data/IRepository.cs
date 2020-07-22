using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnet_core_webapi_demo.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<WeatherForecast>> GetForecasts();

    }
}