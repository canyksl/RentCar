using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DatabaseContext>, IRentalDal
    { 

        public List<CarRentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join cu in context.Customers
                             on r.CustomerId equals cu.UserId
                             join c in context.Cars
                             on r.CarId equals c.Id
                             select new CarRentalDetailDto
                             {
                                 RentalId = r.Id,
                                 CarName = c.Description,
                                 CompanyName = cu.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
    }

       
    }
}
