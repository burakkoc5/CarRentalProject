using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetCarById(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

    }
}
