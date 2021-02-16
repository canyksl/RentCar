using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.DTOs;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICarService:IService<Car>
    {
        IDataResult<List<CarDetailDto>> GetProductDetails();
    }
}
