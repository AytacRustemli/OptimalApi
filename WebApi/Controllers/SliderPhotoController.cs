using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderPhotoController : ControllerBase
    {
        private readonly ISliderPhotoManager _sliderPhotoManager;

        public SliderPhotoController(ISliderPhotoManager sliderPhotoManager)
        {
            _sliderPhotoManager = sliderPhotoManager;
        }

        [HttpGet("getall")]
        public List<SliderPhoto> GetAll()
        {
            return _sliderPhotoManager.GetAllSliderPhoto();
        }

        [HttpPost("add")]
        public object AddSliderPhoto(SliderPhoto sliderPhoto)
        {
            _sliderPhotoManager.Add(sliderPhoto);
            return Ok("SliderPhoto əlavə edildi.");
        }

        [HttpPut("update")]
        public IActionResult UpdateSliderPhoto(SliderPhoto sliderPhoto)
        {
            _sliderPhotoManager.Update(sliderPhoto);
            return Ok(new { status = 200, message = sliderPhoto });
        }

        [HttpDelete("remove")]
        public IActionResult DeleteSliderPhoto(SliderPhoto sliderPhoto)
        {
            _sliderPhotoManager.Remove(sliderPhoto);
            return Ok("SliderPhoto ugurla silindi.");
        }
    }
}
