using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SliderPhotoManager : ISliderPhotoManager
    {
        private readonly ISliderPhotoDal _sliderPhotoDal;

        public SliderPhotoManager(ISliderPhotoDal sliderPhotoDal)
        {
            _sliderPhotoDal = sliderPhotoDal;
        }

        public void Add(SliderPhoto sliderPhoto)
        {
            _sliderPhotoDal.Add(sliderPhoto);
        }

        public List<SliderPhoto> GetAllSliderPhoto()
        {
            return _sliderPhotoDal.GetAll();
        }

        public void Remove(SliderPhoto sliderPhoto)
        {
            _sliderPhotoDal.Delete(sliderPhoto);
        }

        public void Update(SliderPhoto sliderPhoto)
        {
            _sliderPhotoDal.Update(sliderPhoto);
        }
    }
}
