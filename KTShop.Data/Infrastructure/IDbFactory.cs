using System;

namespace KTShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        KTShopDbContext Init();
    }
}