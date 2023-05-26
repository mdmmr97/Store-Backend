namespace Store_Backend.Domain.Services
{
    public interface IImageVerifier
    {
        bool IsImage(byte[] bytes);
    }
}