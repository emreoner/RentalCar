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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentalCarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetAllRentalDetails()
        {
            using (RentalCarDbContext context=new RentalCarDbContext())
            {
                var result = from r in context.Rentals
                             join
                              cs in context.Customers
                             on
                             r.CustomerId equals cs.Id
                             join u in context.Users
                             on
                             cs.UserId equals u.Id
                             join c in context.Cars
                             on
                             r.CarId equals c.Id
                             join clr in context.Colors
                             on
                            c.ColorId equals clr.Id
                             join b in context.Brands
                             on
                             c.BrandId equals b.Id

                             select new RentalDetailDto
                             {
                                 BrandName = b.Name,
                                 CustomerName =$"{u.FirstName} {u.LastName}".ToUpper(),
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
