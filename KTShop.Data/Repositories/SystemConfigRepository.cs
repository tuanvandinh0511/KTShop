﻿using KTShop.Data.Infrastructure;
using KTShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTShop.Data.Repositories
{
    public interface ISystemConfigRepository
    { }
    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    { 
        public SystemConfigRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}
