using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<CarDetailDto> GetCarDetails();
        List<Car> GetAll();
        Car GetCarById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
