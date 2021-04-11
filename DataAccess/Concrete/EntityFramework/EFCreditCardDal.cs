using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EFCreditCardDal : EfEntityRepositoryBase<CreditCard, DatabaseContext>, ICreditCardDal
    {
    }
}
