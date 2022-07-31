using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParamaterController : ControllerBase
    {
        private readonly IParamaterManager _paramaterManager;

        public ParamaterController(IParamaterManager paramaterManager)
        {
            _paramaterManager = paramaterManager;
        }

        [HttpGet("getall")]
        public List<Paramaters> GetAll()
        {
            return _paramaterManager.GetAllParamaters();
        }

        [HttpPost("add")]
        public object AddParamater(Paramaters paramaters)
        {
            _paramaterManager.Add(paramaters);
            return Ok("Paramaters əlavə edildi.");
        }

        [HttpPut("update")]
        public IActionResult UpdateParamater(Paramaters paramaters)
        {
            _paramaterManager.Update(paramaters);
            return Ok(new { status = 200, message = paramaters });
        }

        [HttpDelete("remove")]
        public IActionResult DeleteParamater(Paramaters paramaters)
        {
            _paramaterManager.Remove(paramaters);
            return Ok("Paramaters ugurla silindi.");
        }
    }
}
