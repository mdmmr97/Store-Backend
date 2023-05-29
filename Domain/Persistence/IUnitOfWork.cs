namespace Store_Backend.Domain.Persistence
{
    public interface IUnitOfWork
    {
        IWork Init();
    }
}