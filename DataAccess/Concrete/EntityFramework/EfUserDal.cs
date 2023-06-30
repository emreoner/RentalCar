using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentalCarDbContext>, IUserDal
    {
        public List<OperationClaimDto> GetClaims(User user)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join
                             userOperationClaim in context.UserOperationClaims
                             on
                             operationClaim.Id equals userOperationClaim.OperationClaimId
                             where
                             userOperationClaim.UserId == user.Id

                             select new OperationClaimDto
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };

                return result.ToList();
            }
        }
    }
}
