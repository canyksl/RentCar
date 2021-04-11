using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseContext>, ICarDal
    {
        public CarDetailDto GetCarDetail(int carId)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from car in context.Cars.Where(c => c.Id == carId)

                             join color in context.Colors
                             on car.ColorId equals color.Id

                             join brand in context.Brands
                             on car.BrandId equals brand.Id

                             join i in context.CarImages
                             on car.Id equals i.CarId

                             select new CarDetailDto()
                             {
                                 carId=car.Id,
                                 CarName = car.Description,
                                 CarImage = i.ImagePath,
                                 BrandName = brand.Name,
                                 ColorName = color.Name,
                                 DailyPrice = car.DailyPrice
                             };

                return result.SingleOrDefault();
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (DatabaseContext context=new DatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join r in context.Colors
                             on c.ColorId equals r.Id
                             join i in context.CarImages
                             on c.Id equals i.CarId
                             select new CarDetailDto
                             {
                                 carId=c.Id,
                                 CarName = c.Description, BrandName = b.Name, ColorName = r.Name,
                                 DailyPrice = c.DailyPrice,CarImage=i.ImagePath
                             };
                return result.ToList();
            }

        }
    }
    
}
