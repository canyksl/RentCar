using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.DTOs;
using Entity.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1, BrandId = 2, ColorId = 3, ModelYear = 2016, DailyPrice = 100, Description = "Renault Clio"
                },
                new Car
                {
                    Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2018, DailyPrice = 150, Description = "Ford Focus"
                },
                new Car {Id = 3, BrandId = 3, ColorId = 2, ModelYear = 2017, DailyPrice = 200, Description = "Bmw 1.6i"}

            };
        }

   

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car toUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            toUpdate.Id = car.Id;
            toUpdate.BrandId = car.BrandId;
            toUpdate.ColorId = car.ColorId;
            toUpdate.ModelYear = car.ModelYear;
            toUpdate.DailyPrice = car.DailyPrice;
            toUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car toDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(toDelete);
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetail(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
