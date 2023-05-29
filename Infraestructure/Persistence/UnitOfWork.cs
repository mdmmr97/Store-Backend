using Microsoft.EntityFrameworkCore;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Infraestructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IWork Init()
        {
            return new Work(_dbContext.Database.BeginTransaction());
        }
    }
}
