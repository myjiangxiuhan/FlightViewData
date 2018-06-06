using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using ViewModels;

namespace Web.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    public class AirportController : Controller
    {
        private readonly IAirportService _airportService;

        public AirportController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Airport>> AllAsync()
        {
            return await _airportService.AllAsync();
        }
        [HttpPost("list")]
        public async Task<IEnumerable<Airport>> ListAsync([FromBody] ListViewModel module)
        {
            if (module.PageIndex <= 0) module.PageIndex = 1;
            if (module.PageSize <= 0) module.PageSize = 10;
            if (module.Sort != "id" && module.Sort != "id_desc") module.Sort = null;
            return await _airportService.ListAsync(module.PageSize, module.PageIndex, module.Sort, module.Filter);
        }
        [HttpGet("updata")]
        public async Task<int> UpdataTask()
        {
            return await _airportService.DataUpdataAsync();
        }

        [HttpGet("id/{id}")]
        public async Task<Airport> GetAsync(int id)
        {
            IEnumerable<Airport> airports = await _airportService.SelectAsync(v => v.Id == id);
            Airport[] airportArr = airports.ToArray();
            if (airportArr.Any())
            {
                return airportArr.ToArray()[0];
            }
            return null;
        }
    }
}