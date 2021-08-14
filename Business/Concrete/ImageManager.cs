using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _ımagedal;

        public ImageManager(IImageDal ımagedal)
        {
            _ımagedal = ımagedal;
        }

        public IResult Add(Image ımage)
        {
            IResult result = BusinessRules.Run(CheckIfShipCount(ımage.ShipId));
            if (result != null)
            {
                return result;
            }
            _ımagedal.Add(ımage);
            return new SuccessResult();
        }

        public IResult Delete(Image ımage)
        {
            _ımagedal.Delete(ımage);
            return new SuccessResult();
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_ımagedal.GetAll());
        }
        private IResult CheckIfShipCount(int shipId)
        {
            var result = _ımagedal.GetAll(x => x.ShipId == shipId).Count;
            if (result > 6)
            {
                return new ErrorResult("Bir geminin en fazla 5 adet resmi bulunur");
            }
            return new SuccessResult();
        }
    }
}
