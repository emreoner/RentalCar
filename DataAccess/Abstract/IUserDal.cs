﻿using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaimDto> GetClaims(User user);
    }
}
