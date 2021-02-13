﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
