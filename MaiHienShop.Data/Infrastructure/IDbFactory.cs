using System;

namespace MaiHienShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MaiHienShopDbContext Init();
    }
}