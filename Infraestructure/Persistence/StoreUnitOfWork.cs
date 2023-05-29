using Store_Backend.Domain.Persistence;

namespace Store_Backend.Infraestructure.Persistence
{
    public class StoreUnitOfWork : UnitOfWork, IStoreUnitOfWork
    {
        public StoreUnitOfWork(StoreContext context) : base(context) { }
    }
}
