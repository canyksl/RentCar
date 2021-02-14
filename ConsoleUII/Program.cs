using System;
using System.ComponentModel.Design;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //cargetall();
            //cardetails();
            //userManager.Add(new User { Id = 3, FirstName = "Can", LastName = "Yüksel", Email = "Deneme@deneme.com", Password = "123456" });
            //customerManager.Add(new Customer { UserId=2 , CompanyName = "Deneme" });
            rentalManager.Add(new Rental { Id = 2, CarId = 1, CustomerId = 1, RentDate =new DateTime(2021,02,10) });
            var result = rentalManager.GetRentalDetails();
            if (result.Success)
            {
                foreach (var rent in result.Data)
                {
                    Console.WriteLine(rent.CarName);
                    Console.WriteLine(rent.CompanyName);
                    Console.WriteLine(rent.RentDate);
                    Console.WriteLine(rent.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void cardetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName);
                    Console.WriteLine(car.CarName);
                    Console.WriteLine(car.ColorName);
                    Console.WriteLine(car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //private static void cargetall()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //        Console.WriteLine(car.ModelYear);
        //        Console.WriteLine(car.DailyPrice);
        //        Console.WriteLine("*****************");
        //    }
        //}
    }
}