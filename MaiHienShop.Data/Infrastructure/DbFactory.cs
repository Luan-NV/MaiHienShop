using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiHienShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MaiHienShopDbContext dbContext;

        public MaiHienShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MaiHienShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();

        }
    }
}
