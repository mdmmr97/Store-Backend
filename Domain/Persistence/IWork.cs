namespace Store_Backend.Domain.Persistence
{
    public interface IWork : IDisposable
    {
        void Complete();
        void Rollback();
    }
}