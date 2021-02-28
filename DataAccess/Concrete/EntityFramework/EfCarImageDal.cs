using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal:EfEntityRepositoryBase<CarImage,DatabaseContext>,ICarImageDal
    {
        public List<CarImageDto> GetCarImages()
        {
            using (DatabaseContext context=new DatabaseContext())
            {
                var result = from c in context.Cars
                    join ci in context.CarImages
                        on c.Id equals ci.CarId
                    select new CarImageDto
                    {
                        CarName = c.Description,
                        CarImage = ci.ImagePath
                    };
                return result.ToList();
            }
        }
    }
}
