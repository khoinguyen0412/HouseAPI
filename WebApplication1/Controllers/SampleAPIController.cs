using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    [Route("api/HouseAPI")]
    [ApiController]
    public class SampleAPIController :ControllerBase
    {
        [HttpGet]
        public IEnumerable<House> GetHouse()
        {
            return new List<House>
            {
                new(){ Id = 1, Name="Pool View"},
                new(){ Id = 2, Name = "Hill View" }
            };
        }
    }
}
