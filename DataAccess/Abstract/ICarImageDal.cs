using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarImageDal:IEntityRepository<CarImage>
    {
        List<CarImageDto> GetCarImages();
    }
}
