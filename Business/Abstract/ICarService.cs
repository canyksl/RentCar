using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();
        Car GetById(int id);
        List<CarDetailDto> GetCarDetails();
    }
}
