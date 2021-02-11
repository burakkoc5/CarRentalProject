using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManagerTest();








        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (CarDetailDto car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} model, {1} {2} Günlük Ücret : {3} / Renk : {4}", car.ModelYear, car.BrandName, car.Description, car.DailyPrice, car.ColorName);
            }
            carManager.Add(new Car { BrandId = 4, DailyPrice = 200, Description = "Auris", ColorId = 2, ModelYear = 2018 });
            Console.WriteLine(carManager.GetCarById(5).Data.Description);
        }
    }
}
