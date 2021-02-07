using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetCarById(int carId)
        {
            return _carDal.Get(c=>c.CarId==carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Günlük fiyatı 0 olamaz");
            }

        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
    }
}
