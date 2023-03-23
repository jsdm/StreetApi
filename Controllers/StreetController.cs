using Microsoft.AspNetCore.Mvc;
using StreetApi.Models;

namespace StreetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreetController : ControllerBase
    {
        readonly IStreetRepository _streetRepository;
        public StreetController(IStreetRepository streetRepository)
        {
            _streetRepository = streetRepository;
        }
        [HttpGet]
        
        public ActionResult<List<StreetItem>> Get()
        {
            return Ok(_streetRepository.GetAll());
        }
    }
}
