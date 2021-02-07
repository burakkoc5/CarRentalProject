using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext> , ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             select new CarDetailDto {BrandName = b.BrandName,ColorName = co.ColorName,
                             CarId = c.CarId,DailyPrice=c.DailyPrice,Description=c.Description,ModelYear=c.ModelYear};

                return result.ToList();

            }
        }
    }
}
