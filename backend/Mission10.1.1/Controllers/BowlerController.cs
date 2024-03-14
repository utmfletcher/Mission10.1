using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10._1._1.Data;

namespace Mission10._1._1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp) { 
            _bowlerRepository = temp;
        
        }

        [HttpGet]
        public IEnumerable<Bowlers> Get()
        {
            var bowlerData = _bowlerRepository.Bowlers.ToArray();

            return bowlerData;
        }


    }
}
