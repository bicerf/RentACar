using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ImageCarManager : IImageCarService
    {
        IImagesCarDal _imagesCarDal;

        public ImageCarManager(IImagesCarDal imagesCarDal)
        {
            _imagesCarDal = imagesCarDal;
        }

        [ValidationAspect(typeof(ImageValidator))]
        public IResult Add(IFormFile file, ImagesCar images)
        {
            IResult result = BusinessRules.Run(CheckIfCarImagesLimitExceed(images.CarId));
            if (result != null)
            {
                return result;
            }
            images.ImagePath = FileHelper.AddAsync(file);
            images.ImageDate = DateTime.Now;
            _imagesCarDal.Add(images);
            return new SuccessResult();
        }



        public IResult Delete(ImagesCar images)
        {

            var oldPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _imagesCarDal.Get(p => p.Id == images.Id).ImagePath;

            IResult result = BusinessRules.Run(
                FileHelper.DeleteAsync(oldPath));

            if (result != null)
            {
                return result;
            }

            _imagesCarDal.Delete(images);
            return new SuccessResult();
        }

        public IDataResult<ImagesCar> Get(int id)
        {

            return new SuccessDataResult<ImagesCar>(_imagesCarDal.Get(p => p.Id == id));
        }

        public IDataResult<List<ImagesCar>> GetAll()
        {
            return new SuccessDataResult<List<ImagesCar>>(_imagesCarDal.GetAll());
        }

        public IDataResult<List<ImagesCar>> GetImagesByCarId(int id)
        {
            IResult result = BusinessRules.Run(CheckIfCarImagesExist(id));

            if (result != null)
            {
                return new ErrorDataResult<List<ImagesCar>>(result.Message);
            }

            return new SuccessDataResult<List<ImagesCar>>(CheckIfCarImagesExist(id).Data);
        }
        [ValidationAspect(typeof(ImageValidator))]
        public IResult Update(IFormFile file, ImagesCar images)
        {
            var oldPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _imagesCarDal.Get(p => p.Id == images.Id).ImagePath;
            images.ImagePath = FileHelper.UpdateAsync(oldPath, file);
            images.ImageDate = DateTime.Now;
            _imagesCarDal.Update(images);
            return new SuccessResult();
        }
        private IResult CheckIfCarImagesLimitExceed(int carId)
        {
            var carImageCount = _imagesCarDal.GetAll(p => p.CarId == carId).Count;
            if (carImageCount > 5)
            {
                return new ErrorResult(Messages.ImagesLimitExceded);
            }
            return new SuccessResult();
        }
        private IDataResult<List<ImagesCar>> CheckIfCarImagesExist(int id)
        {
            try
            {
                string path = @"\Images\default.jpg";
                var result = _imagesCarDal.GetAll(c => c.CarId == id).Any();
                if (!result)
                {
                    List<ImagesCar> images = new List<ImagesCar>();
                    images.Add(new ImagesCar { CarId = id, ImagePath = path, ImageDate = DateTime.Now });
                    return new SuccessDataResult<List<ImagesCar>>(images);
                }
            }
            catch (Exception exception)
            {

                return new ErrorDataResult<List<ImagesCar>>(exception.Message);
            }

            return new SuccessDataResult<List<ImagesCar>>(_imagesCarDal.GetAll(p => p.CarId == id).ToList());
        }


    }
}
