using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.DTOs;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
