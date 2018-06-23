namespace MaiHienShop.Data.Infrastructure
{
    public  class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private MaiHienShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        
        public MaiHienShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}