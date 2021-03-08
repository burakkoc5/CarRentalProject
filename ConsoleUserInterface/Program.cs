using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.IO;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();

            //RentalManagerTest();

        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (CarDetailDto car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} model, {1} {2} Günlük Ücret : {3} / Renk : {4}", car.ModelYear, car.BrandName, car.Description, car.DailyPrice, car.ColorName);
            }
            
        }

        private static void RentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Zaten var olan data eklenmeye çalışınca eklenemedi diyor.
            Console.WriteLine(rentalManager.Add(new Rental { CarId = 1, CustomerId = 2, RentDate = DateTime.Now }).Message);
            
            foreach (Rental rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.CarId);
            }


        }
    }
}
