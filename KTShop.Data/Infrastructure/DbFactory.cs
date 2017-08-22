using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private KTShopDbContext dbContext;
        public KTShopDbContext Init()
        {
            return dbContext ?? (dbContext = new KTShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
